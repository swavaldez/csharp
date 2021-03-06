﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray
{
    public class Stack<T> : IEnumerable<T>
    {
        private T[] _arr;
        private int _size;

        public Stack()
        {
           _arr = new T[_size];
        }

        public void Push(T data)
        {
            if (_size == _arr.Length)
            {
                // Doubling (Double the size of array if needed);
                int newLength = _size == 0 ? 4 : _arr.Length * 2;
                T[] newArr = new T[newLength];

                _arr.CopyTo(newArr, 0);
                _arr = newArr;

            }

            _arr[_size++] = data;
            
        }

        public T Pop()
        {
            if (_size == 0) throw new InvalidOperationException("Stack is empty.");
          
          
            var popValue = _arr[_size - 1];
            _arr[_size - 1] = default(T);
            _size--;
            return popValue;

        }

        public T Peek()
        {
            if (_size == 0) throw new InvalidOperationException("Stack is empty.");

            return _arr[_size - 1];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var a in _arr)
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
