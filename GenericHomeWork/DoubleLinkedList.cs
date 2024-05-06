using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHomeWork
{
    internal class DoubleLinkedList<T>
    {
        public Node<T>? Tail { get; set; }
        public Node<T>? Head { get; set; }

        public DoubleLinkedList()
        {
            Tail = null;
            Head = null;
        }

        public void AddNode(T value)
        {
            if (Tail == null)
            {
                Node<T> FirstNode = new Node<T>(value);

                Tail = FirstNode;
                Head = FirstNode;
            }
            else
            {
                Node<T> Node = new Node<T>(value);
                Node.prevNode = Head;
                Head.nextNode = Node;
                Head = Node;
            }
        }

        public void AddNodeFirst(T value)
        {
            if (Tail == null)
            {
                Node<T> FirstNode = new Node<T>(value);

                Tail = FirstNode;
                Head = FirstNode;
            }
            else
            {
                Node<T> Node = new Node<T>(value);
                Tail.prevNode = Head;
                Node.nextNode = Tail;
                Tail = Node;
            }
        }

        public void DeleteValue(T value)
        {
            Node<T>? currentNode = Tail;

            while (currentNode != null)
            {
                if(Equals(currentNode.Value, value))
                {
                    currentNode.prevNode.nextNode = currentNode.nextNode;
                    currentNode.nextNode.prevNode = currentNode.prevNode;
                    currentNode = null;
                    return;
                }
                currentNode = currentNode.nextNode;
            }
        }
        public void DeleteValues(T value)
        {
            Node<T>? currentNode = Tail;

            while (currentNode != null)
            {
                if (Equals(currentNode.Value, value))
                {
                    Node<T>? Temp = currentNode.prevNode;
                    Temp.nextNode = currentNode.nextNode;
                    currentNode = currentNode.nextNode;
                    currentNode.prevNode = Temp;
                }
                else
                {
                    currentNode = currentNode.nextNode;
                }
            }
        }

        public T Pop()
        {
            T poppedValue = Head.Value;

            if (Head == Tail)
            {
                Tail = null;
                Head = null;
            }
            else
            {
                Head = Head.prevNode;
                Head.nextNode = null;
            }

            return poppedValue;
        }

        public T PopFirst()
        {
            T poppedValue = Tail.Value;
            if (Head == Tail)
            {
                Tail = null;
                Head = null;
            }
            else
            {
                Tail = Tail.nextNode;
                Tail.prevNode = null;
            }
            return poppedValue;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            Node<T>? currentNode = Tail;

            while (currentNode != null)
            {
                stringBuilder.Append(currentNode.Value.ToString() + ", ");
                currentNode = currentNode.nextNode;
            }

            return stringBuilder.ToString();
        }

        public void PrintReversedList()
        {
            Node<T> Temp = Head;
            while(Temp != null)
            {
                Console.Write(Temp.Value + ", ");
                Temp = Temp.prevNode;
            }
            Console.WriteLine();
        }
    }
}
