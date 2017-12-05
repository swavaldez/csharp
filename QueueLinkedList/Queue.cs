using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    public class Queue<T> : IEnumerable<T>
    {
        private readonly LinkedList<T> _linkedList = new LinkedList<T>();


        public void Enqueue(T data)
        {
            if (_linkedList.Count == 0)
            {
                _linkedList.AddFirst(data);
            }
            else
            {
                _linkedList.AddLast(data);
            }
          
        }

        public T Dequeue()
        {
            if(_linkedList.Count == 0) throw new InvalidOperationException("The Queue is empty.");

            var value = _linkedList.First.Value;
            _linkedList.RemoveFirst();

            return value;
        }

        public T Peek()
        {
            if (_linkedList.Count == 0) throw new InvalidOperationException("The Queue is empty.");

            return _linkedList.First.Value;
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
