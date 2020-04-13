using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Library.Algorithms
{
    public static class SearchingAlgorithms
    {
        public static bool LinearSearch(int[] input, int key)
        {
            if (input.Length <= 0)
                return false;

            foreach (var item in input)
            {
                if (item == key)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool BinarySearch(int[] input, int key)
        {
            if (input.Length <= 0)
                return false;

            Array.Sort(input);

            int start = 0;
            int end = input.Length - 1;

            while (start <= end)
            {
                var mid = (start + end) / 2;

                if (input[mid] == key)
                    return true;

                if (key > input[mid])
                    end = mid - 1;

                if (key < input[mid])
                    start = mid + 1;
            }


            return false;
        }
    }
}
