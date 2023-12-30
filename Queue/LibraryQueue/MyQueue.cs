namespace LibraryQueue
{
    public class MyQueue<T>
    {
        private readonly List<T> queue;

        public int Count => queue.Count;

        public MyQueue()
        {
            queue = [];
        }

        public void Enqueue(T element)
        {
            queue.Add(element);
        }

        public T Peek()
        {
            return queue[0];
        }

        public T Dequeue()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("Can not execute on empty queue");

            var element = queue[0];
            queue.RemoveAt(0);

            return element;
        }
    }
}
