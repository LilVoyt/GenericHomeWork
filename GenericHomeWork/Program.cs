using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            list.AddNode(1);
            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(2);
            list.AddNode(3);
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Head.Value);
            Console.WriteLine(list.Tail.Value);

            list.AddNodeFirst(99);
            Console.WriteLine(list.ToString());

            list.DeleteValue(2);
            Console.WriteLine(list.ToString());

            list.DeleteValues(2);
            Console.WriteLine(list.ToString());

            //list.PrintReversedList();

            //list.Pop();
            //Console.WriteLine(list.ToString());

            //list.PopFirst();
            //list.PopFirst();
            //Console.WriteLine(list.ToString());
        }
    }
}