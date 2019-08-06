using System;
using System.Text.Json;
using System.Text.Json.Serialization;

using System.Collections.Generic;

namespace JSONstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,object> dictObj = new Dictionary<string,object>();

            dictObj.Add("name","Lincoln");
            dictObj.Add("age",55);
            dictObj.Add("country","United States of America");
            
            Console.WriteLine("\nJSON Object");
            Console.WriteLine("=========================\n");
            foreach(var item in dictObj )
            {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine("\nConverting back to string");
            Console.WriteLine("=========================\n");
            Console.WriteLine(JsonSerializer.ToString<Dictionary<string,object>>(dictObj));
            Console.ReadLine();
        }
    }
}

