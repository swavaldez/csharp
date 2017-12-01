using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public Node<T> Head { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = new Node<T>();
           
        }

        public void AddStart(T data)
        {
            if (Head == null)
            {
                Head = new Node<T> {Value = data};

            }
            else
            {
                var newNode = new Node<T> {Value = data, Next = Head};
                Head = newNode;
            }

            Count++;
        }

        public void AddEnd(T data)
        {
            var newNode = new Node<T> { Value = data, Next = null};
            var current = Head;

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = newNode;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
