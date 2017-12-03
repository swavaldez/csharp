using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 1, 2, 7, 9, 5, 8,10,2,34,5,7,8,1,3,4,5,6,7,8 };

            foreach (var a in arr)
            {
                Console.Write("{0}, ", a);
            }

            SelectionSort(arr);

            Console.WriteLine(string.Empty);
            foreach (var a in arr)
            {
                Console.Write("{0}, ", a);
            }

            Console.ReadKey(true);
        }

        static void SelectionSort(int[] arr)
        {
            int minValue, sortKey = 0, temp = 0;
            minValue = arr[sortKey];

            // iterate each item in array
            for (int i = 0; i < arr.Length; i++)
            {
                // set min value to the item iteration
                minValue = arr[i];

                // check for if the current min value vs all item in array
                for (int j = i; j < arr.Length ; j ++ )
                {
                    if (arr[j] < minValue)
                    {
                        minValue = arr[j];
                        sortKey = j;                        
                    }
                   
                }

                // swap the min value to the current iteration
                temp = arr[i];
                arr[i] = minValue;
                arr[sortKey] = temp;
               
            }
        }
    }
}
