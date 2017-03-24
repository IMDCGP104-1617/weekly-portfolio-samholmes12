using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{


    class Program
    {
        static void Main(string[] args)
    {
            LinkedList list = new LinkedList();
            list.AddToList("Node1");
            list.AddToList("Node2");
            list.AddToList("Node3");
            list.AddToList("Node4");
            list.AddToList("Node5");
            list.RemoveHeadNode();
            list.Print();
            list.RemoveAfter(2);
            list.Print();
            list.RemoveAfter(2);
            list.Print();
            list.AddToList("Node5");
            list.Print();
            Console.ReadLine();
            
            


        }

    }
}

