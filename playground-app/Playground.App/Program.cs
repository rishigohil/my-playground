using Playground.Contracts;
using Playground.Library.Core;
using Playground.Problems.Util;
using System;
using System.CodeDom;
using Newtonsoft.Json.Linq;

namespace Playground.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //var implementingClasses = CoreHelper.GetImplementors(typeof(IProblem));

            //foreach (var item in implementingClasses)
            //{
            //    Helper.InsertNewLines();
            //    Console.WriteLine($"// Executing: { item.Name.ToString() }");
            //    Console.WriteLine("// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ----");

            //    Helper.InvokeMethod(item, "Run");
            //    Helper.InsertNewLines(1);
            //}
            
            //Helper.InsertNewLines(2);
            //Console.WriteLine("Press any key to quit...");
            //Console.ReadLine();
            MethodTest();

        }

        public static void MethodTest()
        {
            var response =
                "[{\r\n    \"courseid\": \"AdClassSched_149126\",\r\n    \"fullname\": \"Career Management\",\r\n    \"shortname\": \"G10\",\r\n    \"roles\": [\"fac\"],\r\n    \"format\": \"topics\",\r\n    \"startdate\": \"2019-04-02T23:00:00-05:00\",\r\n    \"enddate\": \"2021-05-24T23:00:00-05:00\",\r\n    \"timecreated\": \"2019-05-16T00:19:03-05:00\",\r\n    \"timemodified\": \"2019-05-29T23:23:54-05:00\",\r\n    \"categorypath\": \"\\/Miscellaneous\"\r\n}]";

            var token = JToken.Parse(response);


            if (!(token is Array))
            {
                Console.WriteLine("Not Array");
            }
            else
            {
                var enrollArray = JArray.Parse(response);

                var item = enrollArray.SelectToken($"$.[?(@.courseid=='AdClassSched_149126')]");

                Console.WriteLine(item != null && item.HasValues);
            }
        }

    }
}
