using System;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main()
        {
            var url = "http://en-us.appex-rf.msn.com/cg/v5/EN-US/news/today.js?Client-AppVersion=3.0.1.321";
            var today = _download_serialized_json_data<Today>(url);

            Console.ReadKey();
        }

        private static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                try
                {
                    // WebClient.Encoding Property
                    w.Encoding = System.Text.Encoding.UTF8;
                    json_data = w.DownloadString(url);
                }
                catch (Exception e)
                {
                    throw e;
                }
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }
}
