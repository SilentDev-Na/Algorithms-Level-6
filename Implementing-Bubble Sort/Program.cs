using System;
using System.Collections.Generic;
using System.Linq;

namespace Implementing_Bubble_Sort
{
    internal class Program
    {
        // Generic method to print any array of any type
        static void PrintArray<T>(T[] arr) =>
            Console.WriteLine(string.Join(", ", arr.Select(n => $"{n}")));

        static void Main(string[] args)
        {
            // Integer array example
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            // String array example
            string[] arrNames =
            {
                "Dalal", "Bader", "Zaher", "Ibrahim", "Khaled",
                "Mohammed", "Naji", "Abdu-Alrahman", "Hussam", "Cate", "Faisal"
            };

            //============ Sorting Numbers ============

            Console.WriteLine("\nOriginal Array:\n");
            PrintArray<int>(arr); // Print before sorting

            Console.WriteLine("\n");
            BubbleSort(arr); // Perform bubble sort

            Console.WriteLine("Sorted Array:\n");
            PrintArray<int>(arr); // Print after sorting


            //============ Sorting Strings ============

            Console.WriteLine("\n\nOriginal Names:\n");
            PrintArray<string>(arrNames); // Print before sorting

            Console.WriteLine("\n\nSorted Names:\n");
            StringBubbleSort(arrNames); // Perform string bubble sort
            PrintArray<string>(arrNames); // Print after sorting


            Console.ReadKey();
        }
         
        // Bubble Sort for string array (alphabetical order)
        static void StringBubbleSort(string[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Each iteration reduces the comparison range
                for (int j = 0; j < n - i - 1; j++)
                {
                    // Compare two adjacent strings alphabetically
                    if (string.Compare(arr[j], arr[j + 1]) > 0)
                    {
                        // Swap if out of order
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Bubble Sort for integer array
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Loop through array elements
                for (int j = 0; j < n - i - 1; j++)
                {
                    // If current element is greater than next element, swap
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
