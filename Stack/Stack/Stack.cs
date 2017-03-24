using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        public int Length;
        private Node Head;

        public Data Peek()
        {
            if (Head != null)
            {
                return Head.Data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return null;
            }
            
        }

        public void Push(Data Data)
        {
            Node TempNode = new Node();
            TempNode.Data = Data;
            TempNode.Next = Head;
            Length++;
            Head = TempNode;
        }

        public Data Pop()
        {
            if (Head == null) return null;
            Node PoppedOff = Head;
            Head = Head.Next;
            PoppedOff.Next = null;
            Length--;
            return PoppedOff.Data;
        }

        public Data DestroyStack()
        {
            while (Head != null)
            {
                Pop();
            }
            return null;
        }
    

        public void StackLength()
        {
            Console.WriteLine("Stack length: " + Length);
        }
    }
}



