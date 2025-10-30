using System;

namespace PriorityQueueSLL
{
    class Program
    {
        public static void Main()
        {
            PriorityQueue pq = new PriorityQueue();
            pq.Enqueue("Job3", 3);
            pq.Enqueue("Job1", 1);
            pq.Enqueue("Job2", 2);
            pq.Enqueue("Job4", 2);
            pq.Enqueue("Job5", 2);
            pq.Enqueue("Job6", 1);


            pq.Display();

            Console.WriteLine("Dequeued: " + pq.Dequeue());
            Console.WriteLine("Dequeued: " + pq.Dequeue());
            Console.WriteLine("Dequeued: " + pq.Dequeue());
        }
    }
}
