

namespace LibraryQueue
{
    public class MyQueue<T>
    {
        private List<T> queue;

        public int Count { get; private set; }

        public MyQueue()
        {
            Count = 0;
            queue = [];
        }

        public void Enqueue(T element)
        {
            queue.Add(element);
            Count++;
        }

        public T Peek()
        {
            return queue[Count - 1];
        }
    }
}
