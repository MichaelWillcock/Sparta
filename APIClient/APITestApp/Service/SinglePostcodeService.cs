using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp
{
    #region Properties
    //Make a request to the api
    //store the returned data
    //so it can be used in tests
    //store and use configuration information
    #endregion
    class SinglePostcodeService
    {
        #region
        //Restsharp object which handles communications with the api
        public RestClient Client;
        //Newtonsoft object representing the JSON response
        public JObject ResponseContent { get; set; }
        //The postcode used in the api request
        public string PostcodeSelected { get; set; }
        //Store the status code
        public string StatusCode { get; set; }
        //An object model of the response
        public SinglePostcodeResponse ResponseObject { get; set; }
        #endregion

        public SinglePostcodeService()
        {
            Client = new RestClient { BaseUrl = new Uri(AppConfigReader.BaseUrl) };
        }
        public async Task MakeRequestAsync(string postcode)
        {
            //set up request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            PostcodeSelected = postcode;

            //Define the resource path
            request.Resource = $"/postcodes/{postcode.ToLower().Replace(" ", "")}";

            //request and store the response
            var response = await Client.ExecuteAsync(request);

            //Parse our json response content
            ResponseContent = JObject.Parse(response.Content);

            //Capture the status code
            StatusCode = response.StatusCode.ToString();

            //Parse JSON in an object
            ResponseObject = JsonConvert.DeserializeObject<SinglePostcodeResponse>(response.Content);
        }
    }
}
