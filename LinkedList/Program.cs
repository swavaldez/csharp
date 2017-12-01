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
            
            ints.AddStart(5);
            ints.AddStart(7);
            ints.AddStart(9);
            ints.AddEnd(13);
            ints.AddEnd(14);
            ints.AddEnd(13);


            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }

            //ints.PrintNodes();

            Console.ReadKey(true);


        }
    }
}
