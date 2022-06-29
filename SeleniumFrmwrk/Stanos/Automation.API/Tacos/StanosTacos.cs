using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using Driver.Rest.Sharp;
using Newtonsoft.Json;
using RestSharp;

namespace Stanos.Automation.Api
{
    public class StanosTacos
    {
        public static IRestResponse RequestFromStanosTacos(string jwt, string body, string method, string resource)
        {
            if (method == "GET")
            {
                Console.Error.WriteLine("THIS IS THE METHOD " + method.ToString()); //remove debug, add logger
                RestDriver.SetEndpoint(RestDriver.Endpoint + "/tacos/" + resource);
                RestDriver.SetMethod(Method.GET);
                RestDriver.SetRequestHeader("Authorization", "Bearer " + jwt);
                var resp = RestDriver.ExecuteRequest();
                Console.Error.WriteLine("This is the response " + resp.ToString()); //remove this as well
                return resp;

            }
            else
            {
                if (method == "POST")
                {
                    Console.Error.WriteLine("THIS IS THE METHOD " + method.ToString());
                    RestDriver.SetEndpoint(RestDriver.Endpoint + "/tacos/" + resource);
                    RestDriver.SetMethod(Method.POST);
                    RestDriver.SetRequestHeader("Authorization", "Bearer " + jwt);
                    var resp = RestDriver.ExecuteRequest();
                    Console.Error.WriteLine("This is the response " + resp.ToString());
                    return resp;

                }
                else
                {
                    if (method == "PUT")
                    {
                        Console.Error.WriteLine("THIS IS THE METHOD " + method.ToString()); //remove debug, add logger
                        RestDriver.SetEndpoint(RestDriver.Endpoint + "/tacos/" + resource);
                        RestDriver.SetMethod(Method.POST);
                        RestDriver.SetRequestHeader("Authorization", "Bearer " + jwt);
                        var resp = RestDriver.ExecuteRequest();
                        Console.Error.WriteLine("This is the response " + resp.ToString()); //remove
                        return resp;

                    }
                }
                return null;
            }
        }
        public class StanosTacosResponse
        {
            public IRestResponse RequestResponse;
        }
    }
}
