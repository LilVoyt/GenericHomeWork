using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericHomeWork
{
    internal class Node<T>
    {
        public Node<T>? prevNode;
        public T Value;
        public Node<T>? nextNode;

        public Node(T value)
        {
            this.prevNode = null;
            Value = value;
            this.nextNode = null;
        }
    }
}
