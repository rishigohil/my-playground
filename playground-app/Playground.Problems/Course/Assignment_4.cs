using Playground.Contracts;
using Playground.Library.DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground.Problems.Course
{
    public class Assignment_4 : IProblem
    {
        public void Run()
        {
            #region Reverse String

            Console.WriteLine("//Reverse string...");
            var str = "Example text.";
            Console.WriteLine($"Input String: {str}");
            ReverseString(str);

            #endregion


        }

        public bool CanConvert(string currencyFrom, string currencyTo)
        {
            var canConv = false;

            

            return canConv;
        }

        /// <summary>
        /// Serializes the tree to string
        /// </summary>
        /// <param name="root">Binary Search Tree</param>
        /// <returns>Serialized tree</returns>
        public string Serialize(TreeNode root)
        {
            var sb = new StringBuilder();
            var sbRes = Serialize(root, sb);

            return sb.ToString();
        }

        /// <summary>
        /// Deserializes the string to BST.
        /// </summary>
        /// <param name="data">String data</param>
        /// <returns>Binary Tree</returns>
        public TreeNode Deserialize(string data)
        {
            var nodes = new Queue<string>();

            foreach (var item in data.Split(' '))
            {
                nodes.Enqueue(item);
            }

            var resultTree = Deserialize(nodes);

            return resultTree;

        }

        // Encodes a tree to a single string.
        private string Serialize(TreeNode root, StringBuilder res)
        {
            if (root != null)
            {
                res.Append(root.Data + " ");
                Serialize(root.Left, res);
                Serialize(root.Right, res);
            }
            else
            {
                res.Append("# ");
            }

            return res.ToString();
        }

        // Decodes your encoded data to tree.
        private TreeNode Deserialize(Queue<string> nodes)
        {
            var data = nodes.Dequeue();

            if (data == "#")
                return null;
            else
            {
                var treeNode = new TreeNode(Convert.ToInt32(data));
                treeNode.Left = Deserialize(nodes);
                treeNode.Right = Deserialize(nodes);

                return treeNode;
            }
        }

        private void ReverseString(string str)
        {
            var n = str.Length - 1;

            for (int i = n; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}
