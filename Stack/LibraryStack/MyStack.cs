


namespace LibraryStack
{
    public class MyStack
    { 
        private readonly List<object> items;

        public int Count => items.Count;

        public MyStack()
        {
            items = [];
        }

        public void Push(object item)
        {
            items.Add(item);
        }

        public object Pop()
        {
            object lastElement = items[^1];
            items.RemoveAt(Count - 1);
            return lastElement;
        }

        public object Peek()
        {
            return items[^1];
        }
    }
}
