namespace LibraryTree
{
    public class BinaryTree
    {
        public TreeNode? Node { get; private set; }

        public void Insert(int value)
        {
            Node = new TreeNode(value);
        }

        public bool Contains(int value)
        {
            if (Node == null)
                return false;

            return Node.Value == value;
        }
    }
}