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
    class Assignment_1 : IProblem
    {
        public void Run()
        {
            #region Level order traversal

            var inputArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var inputTree = TreeNode.CreateMinimalBst(inputArr);

            LevelOrderTraversal(inputTree);

            #endregion

            Helper.InsertNewLines();

            #region Sort Colors
            
            Console.WriteLine("// Sort colors based on RWB...");
            var sortColorInput = "RBWRB";
            Console.WriteLine($"Sort Colors Input: {sortColorInput}");
            SortColors(sortColorInput);

            #endregion

            Helper.InsertNewLines();

            #region Merge Sorted lists

            #endregion

        }

        private List<string> GeneratePermutations(string input)
        {
            if (string.IsNullOrEmpty(input)) return null;

            return null;
        }

        /// <summary>
        /// Function to print a binary tree level-by-level. 
        /// </summary>
        /// <param name="root">Root of a tree</param>
        private void LevelOrderTraversal(TreeNode root)
        {
            Console.WriteLine("//Level order traversal...");

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int current = 1;
            int next = 0;

            while (queue.Count != 0)
            {
                var currNode = queue.Peek();
                queue.Dequeue();
                current--;

                if(currNode != null)
                {
                    Console.Write($"{currNode.Data} ");
                    queue.Enqueue(currNode.Left);
                    queue.Enqueue(currNode.Right);
                    next += 2;
                }

                if(current == 0)
                {
                    Helper.InsertNewLines();
                    current = next;
                    next = 0;
                }
            }
        }

        /// <summary>
        /// Sort Array of colors.
        /// </summary>
        /// <param name="input"></param>
        private void SortColors(string input)
        {
            
            //Input array will always have RWB?

            var dict = new Dictionary<char, int>();

            var charArr = input.ToCharArray();

            foreach (var c in charArr)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c] += 1;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            PrintColors('R', dict['R']);
            PrintColors('W', dict['W']);
            PrintColors('B', dict['B']);
        }

        /// <summary>
        /// Prints number of characters
        /// </summary>
        /// <param name="c">Character to print</param>
        /// <param name="num">Number of times the character should be printed</param>
        private void PrintColors(char c, int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{c} ");
            }
        }

        /// <summary>
        /// Merge Sorted Lists.
        /// </summary>
        /// <param name="lst1"></param>
        /// <param name="lst2"></param>
        private void MergeSortedLists(List<int> lst1, List<int> lst2)
        {

        }

    }
}
