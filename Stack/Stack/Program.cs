using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Data Info = new Data();
            Stack Mystack = new Stack();

            Mystack.Push(new Data("David"));
            Mystack.Push(new Data("Sarah"));
            Mystack.Push(new Data("Bella"));
            Mystack.Push(new Data("David"));
            Mystack.Push(new Data("Sarah"));
            Mystack.Push(new Data("Bella"));
            Mystack.Push(new Data("David"));
            Mystack.Push(new Data("Sarah"));
            Mystack.Push(new Data("Bella"));

            Info = Mystack.Peek();
            Mystack.StackLength();
            Console.WriteLine(Info.Name);
            Info = Mystack.Pop();
            Info = Mystack.Peek();
            Mystack.StackLength();
            Console.WriteLine(Info.Name);
            Info = Mystack.DestroyStack();
            Info = Mystack.Peek();
            Mystack.StackLength();
            Console.ReadLine();


        }
    }
}
