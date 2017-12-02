using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int>  ints = new LinkedList<int>();
            
            ints.AddFirst(5);
            ints.AddFirst(7);
            ints.AddFirst(9);
            ints.AddLast(13);
            ints.AddLast(14);
            ints.AddLast(13);


            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            //ints.PrintNodes();

            Console.ReadKey(true);


        }
    }
}
