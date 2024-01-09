namespace LibraryTree
{
    public class BinaryTree
    {
        public TreeNode? Node { get; private set; }

        public void Insert(int value)
        {
            Node = InsertRecursive(Node, value);
        }

        private TreeNode InsertRecursive(TreeNode node, int value)
        {
            if (node == null)
                return new TreeNode(value);

            if (value < node.Value)
                node.Left = InsertRecursive(node.Left, value);

            return node;
        }

        public bool Contains(int value)
        {
            if (Node == null)
                return false;

            return Node.Value == value;
        }
    }
}