using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Weekly
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue MyQueue = new Queue();


            MyQueue.Enqueue("yuiuy");
            MyQueue.Enqueue("iopip");
            MyQueue.Enqueue("qweqw");
            MyQueue.Enqueue("tytry");
            MyQueue.Enqueue("sfds");

            MyQueue.Peek();
            MyQueue.Dequeue();
            MyQueue.Peek();
            MyQueue.Dequeue();
            MyQueue.Peek();
            MyQueue.Dequeue();
            MyQueue.Peek();
            MyQueue.CountQueue();
           
            Console.ReadLine();
        }
    }
}
