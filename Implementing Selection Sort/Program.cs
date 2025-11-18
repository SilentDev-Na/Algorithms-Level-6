using System;
using System.Linq;

namespace Implementing_Selection_Sort
{
    internal class Program
    {
        // Original solution: Sort in Ascending order (Smallest → Largest)
        static void SelectionSortASC(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Assume the first element in the unsorted part is the smallest
                int minIndex = i;

                // Find the smallest element in the unsorted part
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[minIndex])
                        minIndex = j;

                // Swap the found minimum with the first element of the unsorted part
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        // Original solution: Sort in Descending order (Largest → Smallest)
        static void SelectionSortDESC(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // Assume the first element in the unsorted part is the largest
                int maxIndex = i;

                // Find the largest element in the unsorted part
                for (int j = i + 1; j < n; j++)
                    if (arr[j] > arr[maxIndex])
                        maxIndex = j;

                // Swap the found maximum with the first element of the unsorted part
                int temp = arr[maxIndex];
                arr[maxIndex] = arr[i];
                arr[i] = temp;
            }
        }

        // Improved solution using a condition delegate (Func)
        // This allows selecting Ascending or Descending or any custom comparison
        static void SelectionSort(int[] arr, Func<int, int, bool> condition)
        {
            if (arr.Length == 0) return;

            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                // We don't know yet if we are choosing min or max, depends on the condition
                int selecteedIndex = i;

                // Compare each element using the passed condition
                for (int j = i + 1; j < n; j++)
                    if (condition(arr[j], arr[selecteedIndex]))
                        selecteedIndex = j;

                // Swap the selected element into the correct position
                int temp = arr[selecteedIndex];
                arr[selecteedIndex] = arr[i];
                arr[i] = temp;
            }
        }

        // Helper method to print array with a message
        static void PrintArray(int[] arr, string message)
        {
            Console.WriteLine("\n" + message + "\n");
            Console.WriteLine(string.Join(", ", arr.Select(n => n.ToString())));
        }

        static void Main(string[] args)
        {
            int[] arr = { 90, 22, 1, 33, 2, 45, 3, 11, 900, 232, 343, 111 };

            PrintArray(arr, "Original Array:");

            // Sort Ascending using the general method
            SelectionSort(arr, (a, b) => a < b);
            PrintArray(arr, "Array After Sort ASC:");

            // Sort Descending using the general method
            SelectionSort(arr, (a, b) => a > b);
            PrintArray(arr, "Array After Sort DESC:");

            Console.ReadKey();
        }
    }
}
