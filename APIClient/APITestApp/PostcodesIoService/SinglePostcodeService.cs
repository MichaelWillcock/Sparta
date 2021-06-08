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
        //Call manager we can access method and it's properties
        public CallManager CallManager { get; set; }
        //Newtonsoft object representing the JSON response
        public JObject Json_Response { get; set; }
        //The postcode used in the api request
        public string PostcodeSelected { get; set; }
        //Data transfer object - it will be a generic type but we will specify the type we want.
        public DTO<SinglePostcodeResponse> SinglePostcodeDTO { get; set; }
        //Response content as a string
        public string PostcodeResponse { get; set; }
        #endregion

        public SinglePostcodeService()
        {
            CallManager = new CallManager();
            SinglePostcodeDTO = new DTO<SinglePostcodeResponse>();
        }
        public async Task MakeRequestAsync(string postcode)
        {
            //make a request
            PostcodeResponse = await CallManager.MakePostcodeRequestAsync(postcode, "postcode");

            //parse a json response
            Json_Response = JObject.Parse(PostcodeResponse);

            //Use DTO to covert JSON string to an object
            SinglePostcodeDTO.DeserializeResponse(PostcodeResponse);
        }

        //Helper method
        public int CodeCount()
        {
            var count = Json_Response["result"]["codes"].ToList().Count();
            return count;
        }
    }
}
