using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
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

            BubbleSort(arr);

            Console.WriteLine(string.Empty);
            foreach (var a in arr)
            {
                Console.Write("{0}, ", a);
            }

            Console.ReadKey(true);
        }

        static void BubbleSort(int[] arr)
        {
            int temp;
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1 ] = arr[j];
                        arr[j] = temp;
                    }
                }

            }

        }
    }
}
