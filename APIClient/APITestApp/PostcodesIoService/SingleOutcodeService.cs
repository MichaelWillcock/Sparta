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
    public class SingleOutcodeService
    {
        #region Properties
        //Call manager we can access method and it's properties
        public CallManager CallManager { get; set; }
        //Newtonsoft object representing the JSON response
        public JObject Json_Response { get; set; }
        // the postcode used in this API request 
        public string OutcodeSelected { get; set; }
        //Data transfer object - it will be a generic type but we will specify the type we want.
        public DTO<SingleOutcodeResponse> SingleOutcodeDTO { get; set; }
        //Response content as a string
        public string OutcodeResponse { get; set; }
        #endregion

        // constructor - creates the RestClient object
        public SingleOutcodeService()
        {
            CallManager = new CallManager();
            SingleOutcodeDTO = new DTO<SingleOutcodeResponse>();
        }

        // method that defines and makes the API request, and stores the responses
        public async Task MakeRequestAsync(string outcode)
        {
            // set up the request
            OutcodeResponse = await CallManager.MakePostcodeRequestAsync(outcode, "outcode");

            //parse a json response
            Json_Response = JObject.Parse(OutcodeResponse);

            //Use DTO to covert JSON string to an object
            SingleOutcodeDTO.DeserializeResponse(OutcodeResponse);
        }
    }
}