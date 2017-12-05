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

        private readonly LinkedList<T> _linkedList = new LinkedList<T>();

        public void Push(T data)
        {
           _linkedList.AddLast(data);
           
        }

        public T Pop()
        {
            if(_linkedList.Count == 0) throw new InvalidOperationException("The stack is empty.");

            var popValue = _linkedList.Last.Value;
            _linkedList.RemoveLast();

            return popValue;

        }

        public T Peek()
        {
            if (_linkedList.Count == 0) throw new InvalidOperationException("The stack is empty.");
            return _linkedList.Last.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
