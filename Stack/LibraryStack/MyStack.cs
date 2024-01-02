
namespace LibraryStack
{
    public class MyStack
    {
        public int Count { get; set; }

        private List<object> items;

        public MyStack()
        {
            Count = 0;
            items = new List<object>();
        }

        public void Push(object v)
        {
            items.Add(v);
            Count++;
        }
    }
}
