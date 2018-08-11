using Playground.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Problems.Course
{
    public class PracticeProblems : IProblem
    {
        public void Run()
        {
            var input = new int[] { 5, 1, 2, 9, 1 };
            var k = 3;

            var result = FindTopKElements(input, k);
        }

        /// <summary>
        /// Given an array of numbers, find the top K
        /// largest numbers in the array. [5,1,2,9,1], K = 3,
        /// return [5,9,2]
        /// </summary>
        /// <param name="input">Input Array</param>
        /// <param name="k">Number of elements </param>
        /// <returns></returns>
        private IList<int> FindTopKElements(int[] input, int k)
        {
            if (k > input.Length)
                return null;

            //Sort the array and print k elements. O(nlogn)
            Array.Sort(input);
            Array.Reverse(input);

            var res = new List<int>();

            for (int i = 0; i < k; i++)
            {
                res.Add(input[i]);
            }

            return res;
        }
    }
}
