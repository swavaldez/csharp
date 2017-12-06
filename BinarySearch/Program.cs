using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,6,7,13,46,75,109,231,236 };

            int value = BinarySearch(arr, 6);

            Console.ReadKey(true);


        }

        static int BinarySearch(int[] arr, int value)
        {
            int low = 0, high = arr.Length - 1;

            while (low < high)
            {
                var mid = (high + low) / 2;

                if (value > arr[mid])
                {
                    low = mid + 1;
                } else if (value < arr[mid])
                {
                    high = mid + 1;
                }
                else
                {
                    return mid;
                }
            }


            return -1;

        }
    }
}
