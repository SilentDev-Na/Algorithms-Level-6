using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 90, 1, 234, 33, 4, 9 };

            Console.WriteLine("Original Array:");
            foreach (int i in arr)
                Console.Write(i + " ");

            Console.WriteLine("\n\nArray After Sort");
            InsertionSort(arr);
            Console.WriteLine(string.Join(" ", arr.Select(n => $"{n}")));

            Console.ReadKey();


        }

        static void InsertionSort(int[] arr)
        {
            //The Length Of The Array
            int n = arr.Length;

            //Loop From 0 to 7
            for (int i = 1; i < n; i++)
            {

                //Take The First Element and its 64
                int key = arr[i];

                // j = 0 AND i = 1
                int j = i - 1;

                //Here i check if the 0 >= 0  AND arr[] is grater than 64 then enter the loop
                //1, 4, 9, 33, 64, 90, 234
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }

    }
}

