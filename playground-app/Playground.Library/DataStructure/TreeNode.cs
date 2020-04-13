using System;

namespace Playground.Library.DataStructure
{
    public class TreeNode
    {
        public int Data { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Parent { get; set; }
        public int Size { get; set; }

        public TreeNode(int data)
        {
            Data = data;
            Size = 1;
        }

        public TreeNode(TreeNode node)
        {
            Data = node.Data;
            Size = node.Size;
            Left = node.Left;
            Right = node.Right;
            Parent = node.Parent;
        }

        public static TreeNode CreateMinimalBst(int[] array)
        {
            return CreateMinimalBst(array, 0, array.Length - 1);
        }

        private static TreeNode CreateMinimalBst(int[] array, int start, int end)
        {
            if (end < start)
            {
                return null;
            }

            var mid = (start + end) / 2;
            var treeNode = new TreeNode(array[mid]);
            treeNode.SetLeftChild(CreateMinimalBst(array, start, mid - 1));
            treeNode.SetRightChild(CreateMinimalBst(array, mid + 1, end));

            return treeNode;
        }

        public void SetLeftChild(TreeNode left)
        {
            Left = left;

            if (left != null)
            {
                left.Parent = this;
            }
        }

        public void SetRightChild(TreeNode right)
        {
            Right = right;

            if (right != null)
            {
                right.Parent = this;
            }
        }

        public int Height()
        {
            var leftHeight = Left != null ? Left.Height() : 0;
            var rightHeight = Right != null ? Right.Height() : 0;

            return 1 + Math.Max(leftHeight, rightHeight);
        }


    }
}
