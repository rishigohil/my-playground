using Playground.Contracts;
using Playground.Library.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Problems.Course
{
    public class Assignment_3 : IProblem
    {
        public void Run()
        {
            #region Custom DS List

            Console.WriteLine("//Custom DS List..");
            var custList = new MyList<int>();
            custList.Add(1);
            custList.Add(3);
            custList.Add(4);
            CustomList(custList);

            #endregion
        }

        private void CustomList(MyList<int> input)
        {
            Console.WriteLine($"Input Size: {input.Length}");
            Console.WriteLine($"Random Item: {input.GetRandom()}");
            Console.WriteLine("Adding 2 in the list..");
            input.Add(2);
            Console.WriteLine($"Updated Size: {input.Length}");
            Console.WriteLine("Removing 2 from the list..");
            input.Remove(2);
            Console.WriteLine($"Updated Size: {input.Length}");
        }
    }
}
