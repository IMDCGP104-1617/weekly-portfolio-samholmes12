using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
    public object data;
    public Node next;



        public Node(object i)
    {
        data = i;
        next = null;
    }

    public void Print()
    {
        Console.WriteLine(data + " ");

            if (next != null)
        {
            next.Print();
        }
    }

   public void AddToList(object data)
    {
        if (next == null)
        {
            next = new Node(data);
        }
        else
        {
            next.AddToList(data);
        }
    }
    
}

}
