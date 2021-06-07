using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestApp.Service
{
    //Make a request to use the API
    class SinglePostcodeService
    {
        //Restsharp object that handles communication with the api
        public RestClient CLient;

        public JObject ResponseContent { get; set; }
        public string PostcodeSelected { get; set; }
        public string StatusCode { get; set; }

        public SinglePostcodeService()
        {
            CLient = new RestClient { BaseUrl = new Url(AppConfigReader.BaseUrl) };
        }

        public Task MakeRequest(string postcode)
        {
            //set up the request
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            PostcodeSelected = postcode;

            //Define the resources path
            request.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";

            //Execute and store the response
            var response = await Client.ExecuteAsync(request);

            //Parse JSON  response content
            ResponseContent = JObject.Parse(response.Content);

            //Capture the status code
            StatusCode = response.StatusCode;

            //PARSE JSON in an object
            ResponseObject = JsonConvert.DeserializeObject<SinglePostcodeService>(response.Content);

        }
    }
}
