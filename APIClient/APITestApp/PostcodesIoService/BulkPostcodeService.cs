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
    class BulkPostcodeService
    {
        #region Properties
        // Call Manager we can access with its methods and properties
        public CallManager CallManager { get; set; }
        // A Newtonsoft object representing the json response
        public JObject Json_Response { get; set; }
        // the postcode used in this API request 
        public string[] PostcodesSelected { get; set; }
        //Data transfer object - it will be a generic type but we will specify the type we want.
        public DTO<BulkPostcodeResponse> BulkPostcodeDTO { get; set; }
        public string BulkPostcodeResponse { get; set; }
        #endregion

        // constructor - creates the RestClient object
        public BulkPostcodeService()
        {
            CallManager = new CallManager();
            BulkPostcodeDTO = new DTO<BulkPostcodeResponse>();
        }

        // method that defines and makes the API request, and stores the responses
        public async Task MakeRequestAsync(string[] postcodes)
        {
            BulkPostcodeResponse = await CallManager.MakeBulkPostcodeRequestAsync(postcodes);

            // Parse JSON into response content
            Json_Response = JObject.Parse(BulkPostcodeResponse);

            BulkPostcodeDTO.DeserializeResponse(BulkPostcodeResponse);
        }
    }
}