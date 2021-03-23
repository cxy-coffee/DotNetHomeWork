using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04_1
{
    class Node<T>
    {
        public Node<T> Next { set; get; }
        public T Data { set; get; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
}
