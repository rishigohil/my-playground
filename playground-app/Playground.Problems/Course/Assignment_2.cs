using Playground.Contracts;
using Playground.Library.Core;
using Playground.Library.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Problems.Course
{
    public class Assignment_2 : IProblem
    {
        /// <summary>
        /// Method to run implemented methods
        /// </summary>
        public void Run()
        {
            #region Two numbers add up to Target number

            Console.WriteLine("//Pair of sum...");
            var sumPairInput = new int[] { 1, 2, 3, 4 };
            var sum = 5;

            Console.WriteLine($"Input: {string.Join(",", sumPairInput)}. TargetSum: {sum}");
            GetTargetNumber(sumPairInput, sum);

            #endregion

            Helper.InsertNewLines();

            #region LCIS Length

            Console.WriteLine("//Length of the contiguous increasing subsequence...");
            var lcisInput = new int[] { -1, 2, 3, 5, 9, 3 };
            Console.WriteLine($"LCIS Input: {string.Join(",", lcisInput)}");
            Console.WriteLine($"Output: {LCISLength(lcisInput)}");

            #endregion

            Helper.InsertNewLines();

            #region Second largest element in BST

            Console.WriteLine("//Second largest element in BST...");

            var inputSecondLargestArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var inputSecondLargestTree = TreeNode.CreateMinimalBst(inputSecondLargestArr);

            SecondLargestInBST(inputSecondLargestTree, 0);

            #endregion
        }

        /// <summary>
        /// Given an array, determine if two numbers in the array add up to a target number. 
        /// </summary>
        /// <param name="inputArr">Input Array</param>
        /// <param name="target">Target of sum</param>
        public void GetTargetNumber(int[] inputArr, int target)
        {
            var set = new HashSet<int>();

            if (inputArr.Length == 0)
                Console.WriteLine("Empty array.");

            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                var t = target - inputArr[i];

                if (t >= 0 && set.Contains(t))
                {
                    Console.WriteLine($"Pair: {inputArr[i]}, {t}");
                }

                set.Add(inputArr[i]);
            }
        }

        /// <summary>
        /// Find the longest length of the contiguous increasing subsequence from an array.  
        /// For eg. [ -1, 2, 3, 5, 9, 3 ] the longest contiguous increasing subsequence is [2,3,5,9]. 
        /// Return 4 in this case.
        /// </summary>
        /// <param name="inputArr">Input Array</param>
        public int LCISLength(int[] inputArr)
        {
            if (inputArr == null || inputArr.Length == 0)
                Console.WriteLine("Invalid array.");

            int count = 0;
            int max = 1;
            int n = inputArr.Length;

            for (int i = 1; i < n; i++)
            {
                if (inputArr[i] > inputArr[i - 1])
                {
                    count++;
                }
                else if(count > max)
                {
                    max = count;
                    count = 0;
                }

                if (i == n - 1 && count >= max)
                    return count;
            }

            return max;
        }

        /// <summary>
        /// Write a function to find the next largest element in a binary search tree.
        /// </summary>
        /// <param name="node">Tree node</param>
        /// <param name="c">Counter</param>
        public void SecondLargestInBST(TreeNode node, int c)
        {
            if (node == null || c >= 2)
                return;

            SecondLargestInBST(node.Right, c);

            c++;

            if (c == 2) Console.WriteLine($"Second largest node: {node.Data}");

            SecondLargestInBST(node.Left, c);
        }


    }
}
