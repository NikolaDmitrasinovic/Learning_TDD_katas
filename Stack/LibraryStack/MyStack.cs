
namespace LibraryStack
{
    public class MyStack
    {
        public int Count { get; private set; }

        private readonly List<object> items;

        public MyStack()
        {
            Count = 0;
            items = [];
        }

        public void Push(object item)
        {
            items.Add(item);
            Count++;
        }
    }
}
