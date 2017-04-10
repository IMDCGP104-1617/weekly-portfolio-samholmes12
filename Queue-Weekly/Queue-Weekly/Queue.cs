using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Weekly
{
    class Queue
    {
        public Node Head;
        public Node Tail;
        public int Count = 0;

        public void Peek()
        {
            Console.WriteLine(Head.Name);
        }

        public void Enqueue(string Name)
        {
            Node newNode = new Node(Name);

            if (Head == null)
            {
                Head = newNode;
                Tail = Head;
            }
            else
            {
                Tail.next = newNode;
                Tail = Tail.next;
            }
            Count++;
        }

        public void Dequeue()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Head = Head.next;
            Count--;
        }

        public void IsEmpty()
        {
            if (Head == null)
            {
                Console.WriteLine("Queue Is Empty");
            }
            else
            {
                Console.WriteLine("Queue is not Empty");
            }
        }

        public void CountQueue()
        {
            Console.WriteLine("In Queue: " + Count);
        }
    }
}
