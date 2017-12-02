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
        public int Count { get; private set; }

        public LinkedList()
        {

        }

        public T First
        {
            get
            {
                if (Head == null)
                    return default(T);

                return Head.Value;
            }
        }

        public T Last
        {
            get
            {
                if (Head == null)
                    return default(T);

                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }

                return current.Value;
            }
        }


        public void AddFirst(T data)
        {
            if (Head == null)
            {
                Head = new Node<T> { Value = data };

            }
            else
            {
                var newNode = new Node<T> { Value = data, Next = Head };
                Head = newNode;
            }

            Count++;
        }

        public void AddLast(T data)
        {
            var newNode = new Node<T> { Value = data, Next = null };
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

            Count++;
        }

        public void RemoveFirst()
        {
            if (Count == 1)
            {
                Head = null;
            }
            else
            {
                Head = Head.Next;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (Count == 1)
            {
                Head = null;
            }
            else
            {
                var current = Head;
                int removeCount = 1;
                while (current.Next != null)
                {                  
                    current = current.Next;
                    removeCount++;

                    if(removeCount == Count - 1)
                    {
                        current.Next = null;
                        Count--;
                        break;
                    }
                }
                
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
