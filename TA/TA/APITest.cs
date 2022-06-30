using FluentAssertions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace DemoAutomation
{
    /// <summary>
    /// Class to run API Tests
    /// </summary>
    public class APITests
    {
        /// <summary>
        /// Test annotation to run API test
        /// </summary>
        /// 

        //Creating RestClient
        public RestClient client;

        public RestClient GetClient()
        {
            return new RestClient("https://reqres.in");  //returning RestClient
        }

        //API GetReq Test
        [Test]
        public async Task Test1()
        {

            client = GetClient();
            var request = new RestRequest("/api/users?page=2" , Method.Get);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;

            var response = await client.ExecuteAsync(request);

            response.StatusCode.Should().Be(HttpStatusCode.OK);  //Verifying Status Code

            var content = response.Content;

            var user = JsonConvert.DeserializeObject<User>(content);

            if (user.id == 10)
            {

                Assert.AreEqual("Byron",user.first_name,"first_name does not match");  // Matching first_name in response with expected
            }

        }

        //API Post req Test
        [Test]
        public async Task Test2()
        {

            client = GetClient();

            var request = new RestRequest("/api/users", Method.Post);
            request.AddHeader("Accept", "application/json");
            request.AddJsonBody(new User
            {
                name = "Bryant",
                job ="BA"

            });

            var response = await client.ExecuteAsync(request);

            response.StatusCode.Should().Be(HttpStatusCode.Created); // Verifying status Code

            
            var content = response.Content;

            var user = JsonConvert.DeserializeObject<User>(content);


            Assert.IsNotNull(user.id, "Id is not generated successfully");   //Verifying Id is generated
            
            
            JSchema schema = JSchema.Parse(System.IO.File.ReadAllText("schema.json"));
            JObject jsonobject = JObject.Parse(response.Content);

            var isValidSchema = jsonobject.IsValid(schema); 

            Assert.IsTrue(isValidSchema, "Response does not match with schema "); // Validating Json schema of response

                       

        }

        
    }
}