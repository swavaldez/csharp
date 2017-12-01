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
    public class LinkedList<T> 
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = new Node<T>();
            Tail = new Node<T>();
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

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var current = Head;
                
                while (current.Next != null)
                {
                    current = current.Next;
         
                }

                current.Next = newNode;

            }
        }

        public void PrintNodes()
        {
            var current = Head;
            while (current.Next != null)
            {
                Console.WriteLine("Node : {0}", current.Value);
                current = current.Next;
                

            }
        }

        


       
    }
}
