using System;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace APIClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////SINGLE POSTCODE REQUEST/////////////
            #region
            //Our client property is equal to a new rest sharp object that is part of the rest sharp library.
            //this is going to create a new uri object and is going to encapsulate all the information we need
            //to make the api core. It also tell sus to send authenticated HTTP requests.
            #endregion

            var restClient = new RestClient("https://api.postcodes.io/");

            #region
            //set up the request. WE are going to create a request object.
            #endregion
            var restRequest = new RestRequest();
            #region
            //set method as GET
            #endregion
            restRequest.Method = Method.GET;
            #region
            //We are now going to specify our request header. Specify the content type.
            #endregion
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.Timeout = -1;
            #region
            //We are now going to est up the resource EC2y 5AS
            //Get rid of all spaces and lower cases.
            #endregion
            var postcode = "EC2Y 5AS";
            restRequest.Resource = $"postcodes/{postcode.ToLower().Replace(" ", "")}";
            #region
            //now we are going to use our rest client to execute our request and it will also store
            //the bulkResponse.
            #endregion
            var singleResponse = restClient.Execute(restRequest);
            Console.WriteLine("Rest singleResponse content (as string)");
            Console.WriteLine(singleResponse.Content);

            ////////////BULK POSTCODE REQUEST//////////////////
            JObject postcodes = new JObject
            {
                new JProperty("postcodes", new JArray(new string[]{"OX49 5NU", "M32 OJG", "NE30 1DP"}))
            };
            var client = new RestClient("https://api.postcodes.io/postcodes/");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(postcodes.ToString());
            IRestResponse bulkResponse = client.Execute(request);
            Console.WriteLine(bulkResponse.Content);

            ///////////////////Parse our bulkResponse to a JObject and query that JObject
            var bulkJSONResponse = JObject.Parse(bulkResponse.Content);
            //Console.WriteLine(bulkJSONResponse["status"]);
            //Console.WriteLine(bulkJSONResponse["status"][0]["query"]);
            //Console.WriteLine(bulkJSONResponse["status"][0]["query"]["region"]);

            ////Deserialize response to C# object////
            var singlePostCode = JsonConvert.DeserializeObject<SinglePostcodeResponse>(singleResponse.Content);
            var bulkPostCode = JsonConvert.DeserializeObject<BulkPostcodeResponse>(bulkResponse.Content);

            Console.WriteLine("Single Postcode response:");
            Console.WriteLine(singlePostCode.Status);
            Console.WriteLine(singlePostCode.result.region);
            Console.WriteLine();
            Console.WriteLine("Bulk Postcode response:");
            Console.WriteLine(bulkPostCode.status);
            foreach(var result in bulkPostCode.result)
            {
                Console.WriteLine(result.query);
                Console.WriteLine(result.result.region);
            }

            //var singleOutcode = JsonConvert.DeserializeObject<OutcodeResponse>(out)
        }
    }
}
