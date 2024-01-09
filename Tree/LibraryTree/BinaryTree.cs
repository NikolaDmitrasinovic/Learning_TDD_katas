namespace LibraryTree
{
    public class BinaryTree
    {
        public TreeNode? Node { get; set; }

        public void Insert(int value)
        {
            Node = new TreeNode(value);
        }

        public bool Contains(int value)
        {
            return Node.Value == value;
        }
    }
}