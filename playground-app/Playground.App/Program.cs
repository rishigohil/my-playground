using Playground.Contracts;
using Playground.Library.Core;
using Playground.Problems.Util;
using System;

namespace Playground.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var implementingClasses = CoreHelper.GetImplementors(typeof(IProblem));

            foreach (var item in implementingClasses)
            {
                Helper.InsertNewLines();
                Console.WriteLine($"// Executing: { item.Name.ToString() }");
                Console.WriteLine("// ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ---- ----");

                Helper.InvokeMethod(item, "Run");
                Helper.InsertNewLines(1);
            }
            
            Helper.InsertNewLines(2);
            Console.WriteLine("Press any key to quit...");
            Console.ReadLine();
        }
    }
}
