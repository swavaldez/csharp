using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArray
{
    public class Queue<T> : IEnumerable<T>
    {
        private T[] _array = new T[0];
        private int _size;

        public void Enqueue(T data)
        {
            if (_size == _array.Length)
            {
                int newSize = _size == 0 ? 4 : _size * 2;
                T[] newArr = new T[newSize];
                _array.CopyTo(newArr, 0);
                _array = newArr;

            }

            _array[_size++] = data;
        }

        public T Dequeue()
        {
            if(_size == 0) throw new InvalidOperationException("The queue is empty");
            var value = _array[0];

            T[] newArr = new T[_array.Length];
            for (int i = 1; i < _array.Length; i++)
            {
                newArr[i - 1] = _array[i];
            }

            _array = newArr;
            _size--;

            return value;


        }

        public T Peek()
        {
            if (_size == 0) throw new InvalidOperationException("The queue is empty");

            return _array[0];
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var a in _array)
            {
                yield return a;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
