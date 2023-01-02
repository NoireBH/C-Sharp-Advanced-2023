using System;

namespace CustomQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomQueue queue = new CustomQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.Dequeue();
            Console.WriteLine(queue.Peek());
            queue.ForEach(x => Console.WriteLine(x));
            queue.Clear();
            queue.Enqueue(1);
            queue.ForEach(x => Console.WriteLine(x));

        }
    }
}
