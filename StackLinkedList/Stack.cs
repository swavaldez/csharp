using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StackLinkedList
{
    /// <summary>
    /// This a basic implementation of Stack using a Linked List
    /// Pros: No Hard Size *Depth* Limit
    /// Easy to implement
    /// => No Bound Checking
    /// => Empty list  = Empty stack
    /// Cons: Memory allocation on push;
    /// =>Per Node memory overhead
    /// => Potential performance issues;
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T> : IEnumerable<T>
    {
        class Node<T>
        {
            public T Value { get; set; } 
            public Node<T> Next { get; set; }
        }

        class LinkedList<T>
        {
            public Node<T> Head { get; set; }
            public int Count { get; set; }
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

            public T First
            {
                get
                {
                    if (Head == null)
                        return default(T);

                    return Head.Value;
                }
            }
        }

        private readonly LinkedList<T> _linkedList = new LinkedList<T>();

        public void Push(T data)
        {
           
           _linkedList.AddFirst(data);
           
        }

        public T Pop()
        {
            if(_linkedList.Count == 0) throw new InvalidOperationException("The stack is empty.");

            var popValue = _linkedList.First;
            _linkedList.RemoveFirst();

            return popValue;

        }

        public T Peek()
        {
            if (_linkedList.Count == 0) throw new InvalidOperationException("The stack is empty.");
            return _linkedList.First;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = _linkedList.Head;
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
