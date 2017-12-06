using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 1, 2, 7, 9, 5, 8 };

            foreach (var a in arr)
            {
                Console.Write("{0}, ", a);
            }

            InsertionSort(arr);

            Console.WriteLine(string.Empty);
            foreach (var a in arr)
            {
                Console.Write("{0}, ", a);
            }

            Console.ReadKey(true);
        }

        static void InsertionSort(int[] arr)
        {
            int selected, temp, sortkey;

           
        }
    }
}
