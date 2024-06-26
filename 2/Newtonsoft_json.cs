﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace JsonWork
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
            // JToken là base class của JObject, JArray, JValue, dùng để biểu diễn Json 1 cách tổng quát
            JToken jsonData = JToken.Parse(json);

            // JObject: child của JToken, hỗ trợ access các field dễ dàng hơn
            // Access field "ADDRESS_MAP" like a dict, we get a JToken
            // then get its Value as a JObject
            JObject addressMap = jsonData["ADDRESS_MAP"].Value<JObject>();

            // Nếu field đó của json là 1 string, ta có thể access đc chúng ngay dưới dạng 1 string
            // string addressMap = (string)jsonData["ADDRESS_MAP"];

            // Access Properties() list of a JObject
            // Then map their name to a string list
            List<string> keys = addressMap.Properties().Select(p => p.Name).ToList();

            foreach (string k in keys)
            {
                Console.WriteLine(k);
            }

            // Convert with a list field
            JArray addressLocation = (JArray)jsonData["ADDRESS_MAP"]["ADDRESS_LOCATION"];
            // Traverse through the array, each item is a JToken
            foreach (JToken item in addressLocation)
            {
                Console.Writeln($"Field ID: {(int)item["FieldID"]}";
            }

            JArray location = (JArray)jsonData["ADDRESS_MAP"]["LOCATION"];
            foreach (JToken item in location)
            {
                // JToken chỉ access đc các item 1 lớp, nếu muốn access lớp con tiếp theo:
                Console.Writeln($"Location keyword: {(string)item.SelectToken("keyword.1")}";
            }
        }
    }
}
