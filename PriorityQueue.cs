using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueSLL
{
    public class PriorityQueue
    {
        private Node head = null;

        // Insert based on priority (ascending priority)
        public void Enqueue(string jobTitle, int priority)
        {
            Node newNode = new Node(jobTitle, priority);

            // If queue is empty OR new node has higher priority than head
            if (head == null || priority > head.priority)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node temp = head;

                // Find the right place to insert
                while (temp.next != null && temp.next.priority >= priority)
                {
                    temp = temp.next;
                }

                newNode.next = temp.next;
                temp.next = newNode;
            }

            //Console.WriteLine($"Inserted {jobTitle} with priority {priority}");
        }

        // Remove highest priority element
        public string Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Priority Queue is empty");
            }

            string job = head.jobTitle;
            head = head.next;
            return job;
        }

        // Display queue
        public void Display()
        {
            Node temp = head;
            Console.Write("Priority Queue: ");
            while (temp != null)
            {
                Console.Write($"[{temp.jobTitle}, {temp.priority}] -> ");
                temp = temp.next;
            }
            Console.WriteLine("null");
        }
    }
}
