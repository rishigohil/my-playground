using Playground.Contracts;
using Playground.Library.DataStructure;
using System;
using System.Collections.Generic;

namespace Playground.Problems.Course
{
    public class LeetCodeProblems : IProblem
    {
        public void Run()
        {
            Console.WriteLine("// Vertical order traversal...");
            var sampleArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sampleTree = TreeNode.CreateMinimalBst(sampleArray);

            PrintVerticalOrderTree(sampleTree);
        }

        public void PrintVerticalOrderTree(TreeNode root)
        {
            var dict = new Dictionary<int, List<int>>();
            var hd = 0;
            VerticalOrderTraversal(root, hd, dict);

            foreach (var item in dict)
            {
                Console.WriteLine(string.Join(",", item.Value));
            }
        }

        private void VerticalOrderTraversal(TreeNode root, int hd, Dictionary<int, List<int>> m)
        {
            if (root == null)
                return;

            if (m.ContainsKey(hd))
            {
                m[hd].Add(root.Data);
            }
            else
            {
                var val = new List<int>();
                m.Add(root.Data, val);
            }

            VerticalOrderTraversal(root.Left, hd - 1, m);
            VerticalOrderTraversal(root.Right, hd + 1, m);
        }




    }
}
