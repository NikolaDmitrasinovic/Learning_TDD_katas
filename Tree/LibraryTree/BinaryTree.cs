﻿namespace LibraryTree
{
    public class BinaryTree
    {
        public TreeNode? Root { get; private set; }

        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if (node == null)
                return new TreeNode(value);

            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);
            else if (value > node.Value)
                node.Right = InsertRecursive(node.Right, value);

            return node;
        }

        public bool Contains(int value)
        {
            if (Root == null)
                return false;

            return Root.Value == value;
        }
    }
}