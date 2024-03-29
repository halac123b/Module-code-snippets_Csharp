﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeModules
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json =
            @"{
                ""ADDRESS_MAP"":{

                    ""ADDRESS_LOCATION"":
                    [
                        {
                        ""type"":""separator"",
                        ""name"":""Address"",
                        ""value"":"""",
                        ""FieldID"":40
                        },
                        {
                        ""type"":""separator"",
                        ""name"":""Address"",
                        ""value"":"""",
                        ""FieldID"":40
                        }
                    ],
                    ""LOCATION"":{
                        ""type"":""locations"",
                        ""name"":""Location"",
                        ""keyword"":{
                            ""1"":""LOCATION1""
                        },
                        ""value"":{
                            ""1"":""United States""
                        },
                        ""FieldID"":41
                    },
                    ""FLOOR_NUMBER"":{
                        ""type"":""number"",
                        ""name"":""Floor Number"",
                        ""value"":""0"",
                        ""FieldID"":55
                    },
                    ""self"":{
                        ""id"":""2"",
                        ""name"":""Address Map""
                    }
                }
            }";

            // Parse string json to JToken
            JToken jsonData = JToken.Parse(json);
            // Access field "ADDRESS_MAP" like a dict, we get a JToken
            // then get its Value as a JObject
            JObject addressMap = jsonData["ADDRESS_MAP"].Value<JObject>();

            // Access Properties() list of a JObject
            // Then map their name to a string list
            List<string> keys = addressMap.Properties().Select(p => p.Name).ToList();

            foreach (string k in keys)
            {
                Console.WriteLine(k);
            }
            
            // Convert with a list field
            JArray addressLocation = (JArray)jsonData["ADDRESS_MAP"]["ADDRESS_LOCATION"];
        }
    }
}
