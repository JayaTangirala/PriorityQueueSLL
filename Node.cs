using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueueSLL
{
    internal class Node
    {
        public string jobTitle;
        public int priority;
        public Node next;

        public Node(string jobTitle, int priority)
        {
            this.jobTitle = jobTitle;
            this.priority = priority;
            next = null;
        }
    }
}
