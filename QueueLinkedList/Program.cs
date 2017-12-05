using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(33);
            queue.Enqueue(7);
            queue.Enqueue(2);
            queue.Enqueue(25);
            queue.Enqueue(32);

            foreach (var q in queue)
            {
                Console.WriteLine(q);
            }

            var d = queue.Dequeue();


            Console.WriteLine("Dequeue: " + d);
            foreach (var q in queue)
            {
                Console.WriteLine(q);
            }

            queue.Enqueue(31);

            Console.WriteLine("Enqueue 31");
            foreach (var q in queue)
            {
                Console.WriteLine(q);
            }

            var s = queue.Peek();
            Console.WriteLine("Peek: " + s);

            Console.ReadKey(true);

          
        }
    }
}
