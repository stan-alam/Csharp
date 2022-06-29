using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using Driver.Rest.Sharp;
using Newtonsoft.Json;
using RestSharp;

namespace Stanos.Automation.Api
{
    public class GenerateJWT
    {
        public static string resource = "/accesstokens/"; //update these
        public static String GetJWTToken(string userId, string clientId, string tenantId)
        {
            RestDriver.SetEndpoint(RestDriver.Endpoint + resource);
            RestDriver.SetMethod(Method.POST);
            RestDriver.SetRequestHeader("Content-Type", "application/json");
            IDictionary<String, object> body = new Dictionary<String, object>();
            body.Add("userId",     userId);
            body.Add("clientId", clientId);
            body.Add("tenantId", tenantId);
            RestDriver.SetBody(JsonConvert.SerializeObject(body));
            var resp = RestDriver.ExecuteRequest();
            var response = JsonConvert.DeserializeObject<JwtResponse>(resp.Content);
            Console.Error.WriteLine("jwt repsonse "  + response.accessToken); //remove this, add logger
            return response.accessToken;
        }

        public static bool ContainsAccessToken(string accessTokentoken)
        {
            if (accessToken == null || accessToken.Equals("") || accessToken.Equals(" "))
            {
                Console.Error.WriteLine("Error");
                return false;
            }
            Console.Error.WriteLine("here's the token " + accessToken)
            return true;
        }
    }

    public class JwtResponse
    {
        public string accessToken { get; set; }
        public DateTime date { get; set; }
    }
}
