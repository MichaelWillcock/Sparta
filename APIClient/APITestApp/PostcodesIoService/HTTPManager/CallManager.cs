using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp
{
    public class CallManager
    {
        //Restsharp obejct that handles communications with our API
        private readonly IRestClient _client;
        //Capture status description
        public string StatusDescription { get; set; }


        public CallManager()
        {
            _client = new RestClient(AppConfigReader.BaseUrl);
        }

        public async Task<string> MakePostcodeRequestAsync(string postcode, string method)
        {
            //set up request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");

            //Define the resource path
            if (method == "postcode")
            {
                request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";
            }
            else { request.Resource = $"outcodes/{postcode.ToLower().Replace(" ", "")}"; }

            //request and store the response
            var response = await _client.ExecuteAsync(request);

            //Capture the status code
            StatusDescription = response.StatusDescription.ToString();

            return response.Content;
        }
        public async Task<string> MakeBulkPostcodeRequestAsync(string[] postcodes)
        {
            //set up request
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");

            //Define the resource path
            request.Resource = "/postcodes";

            var postcodesJson = new JObject
        {
            new JProperty ( "postcodes", new JArray { postcodes } )
        };
            request.AddJsonBody(postcodesJson.ToString());

            //request and store the response
            var response = await _client.ExecuteAsync(request);

            //Store the status description
            StatusDescription = response.StatusDescription.ToString();

            return response.Content;

        }
    }
}
