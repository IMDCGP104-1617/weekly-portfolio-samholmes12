using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   

    public class LinkedList
    {
        public Node TempNode;
        public Node headNode;
        public int CountNode;

        public LinkedList()
        {
            headNode = null;

        }

        public void AddToList(object data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
                CountNode++;
            }
            else
            {

                headNode.AddToList(data);
                CountNode++;
            }
        }


        public void RemoveHeadNode( )
        {
            if (headNode != null)
            {
                headNode = headNode.next;
                CountNode--;
            }
            else
            {
                Console.WriteLine("No element exist in this linked list.");
            }
        }

        public void RemoveAfter(int NodeToDelete)
        {
            Node Current = headNode;

            for (int i = 0; i < NodeToDelete - 1; i++ )
            {
                Current = Current.next;
                Current.next = Current.next.next;
            }
            CountNode--;


        }


        public void Print()
        {
            if (headNode != null)
            {
               
                headNode.Print();
                Console.WriteLine("NodeCount: " + CountNode);
            }
        }



    }
}
