


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

        public T Dequeue()
        {
            var element = queue[Count - 1];
            queue.RemoveAt(Count - 1);
            Count--;
            return element;
        }
    }
}
