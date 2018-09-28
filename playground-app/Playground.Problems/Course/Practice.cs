using Playground.Contracts;
using Playground.Library.Core;
using Playground.Problems.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Problems.Course
{
    public class Practice : IProblem
    {
        public void Run()
        {
            Helper.InsertNewLines();

            #region MoveZeroes

            Console.WriteLine("//Move Zeroes...");
            var zeroesInput = new int[5] { 0, 1, 0, 3, 5 };
            Console.WriteLine($"Input: {string.Join(",", zeroesInput)}");
            MoveZeroes(zeroesInput);
            Console.WriteLine($"Output: {string.Join(",", zeroesInput)}");

            #endregion

            Helper.InsertNewLines();

            #region Add Binary

            Console.WriteLine("//Add Binary...");
            var numA = "0010";
            var numB = "1101";
            var sumBinary = AddBinary(numA, numB);
            Console.WriteLine($"Binary Sum: {numA} + {numB} = {sumBinary}");

            #endregion

            #region First Unique Character

            Console.WriteLine("//First Unique Character...");
            var uniqueStr = "iiRts";
            Console.WriteLine($"Input {uniqueStr}. Unique Char Index: {FirstUniqChar(uniqueStr)}");

            #endregion
        }

        public void MoveZeroes(int[] nums)
        {
            var len = nums.Length;
            var a = 0;
            var b = a + 1;

            while (a < len && b < len)
            {
                if(nums[a] == 0 && nums[b] != 0)
                {
                    var temp = nums[a];
                    nums[a] = nums[b];
                    nums[b] = temp;
                }
                else if (nums[a] != 0)
                {
                    a++;
                    b++;
                }
                else
                {
                    b++;
                }
            }
        }

        public string AddBinary(string numA, string numB)
        {
            if (string.IsNullOrEmpty(numA)) return numB;
            if (string.IsNullOrEmpty(numB)) return numA;

            int i = numA.Length - 1;
            int j = numB.Length - 1;

            var stack = new Stack<int>();
            var sb = new StringBuilder();
            var carry = 0;
            var sum = 0;

            while (i >= 0 || j >= 0)
            {
                sum = carry;

                if (i >= 0) sum += numA[i--] - '0';
                if (j >= 0) sum += numB[j--] - '0';

                carry = sum / 2;

                stack.Push(sum % 2);
            }

            if (carry != 0) sb.Append("1");

            while (stack.Count != 0)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }

        public int FirstUniqChar(string s)
        {
            var ignoreSet = new HashSet<char>();
            var dict = new Dictionary<char, int>();

            int len = s.Length;

            for (int i = 0; i < len; i++)
            {
                var c = s[i];
                if (dict.ContainsKey(c))
                {
                    dict.Remove(c);
                    ignoreSet.Add(c);
                }
                else if (!ignoreSet.Contains(c))
                {
                    dict.Add(c, i);
                }
            }

            if(dict.Count != 0)
            {
                dict.OrderBy(x => x.Value);

                return dict.FirstOrDefault().Value;
            }
            else
            {
                return -1;
            }
        }
    }
}
