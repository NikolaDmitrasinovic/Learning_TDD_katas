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
            var element = queue[0];
            queue.RemoveAt(0);

            return element;
        }
    }
}
