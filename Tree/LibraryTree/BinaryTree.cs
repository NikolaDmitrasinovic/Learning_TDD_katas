namespace LibraryTree
{
    public class BinaryTree
    {
        public TreeNode? Root { get; private set; }

        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }

        private static TreeNode InsertRecursive(TreeNode node, int value)
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
            return ContainsRecursive(Root, value);
        }

        private static bool ContainsRecursive(TreeNode node, int value)
        {
            if (node == null)
                return false;

            if (value == node.Value)
                return true;
            else if (value < node.Value)
                return ContainsRecursive(node.Left, value);
            else
                return ContainsRecursive(node.Right, value);
        }

        public static void ReturnTree(TreeNode node, List<int> sortedTree)
        {
            if (node != null)
            {
                ReturnTree(node.Left, sortedTree);
                sortedTree.Add(node.Value);
                ReturnTree(node.Right, sortedTree);
            }
        }
    }
}