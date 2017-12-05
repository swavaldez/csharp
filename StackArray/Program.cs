using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);
            stack.Push(1);
            stack.Push(4);
            stack.Push(5);

            foreach (var value in stack)
            {
                Console.WriteLine(value);
            }



            Console.WriteLine();

            Console.WriteLine("POP: " + stack.Pop());
            Console.WriteLine("POP: " + stack.Pop());

            Console.WriteLine();


            foreach (var value in stack)
            {
                Console.WriteLine(value);
            }



            Console.WriteLine("POP: " + stack.Pop());

            Console.ReadKey(true);
        }
    }
}
