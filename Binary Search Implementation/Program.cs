using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Implementation
{
    internal class Program
    {
        static int BinarySearch(int[] arr, int target)
        {
            int start = 0, end = arr.Length -1;

            int count = 0;
            while (start <= end)
            {
                int middle = start + (end - start) / 2;


                count++;
                Console.WriteLine("Trail = " + count);

                if(arr[middle] == target)
                    return middle;

                if(target > arr[middle])
                    start = middle  +1;

                else
                    end = middle - 1;
            }

            return -1;
        }

        static int ReadNumber(string Message)
        {
            Console.Write(Message + " ");

            int value = 0;

            int.TryParse(Console.ReadLine(), out value);
            return value;
        }
        static void Main(string[] args)
        {
            int[] arr = { 29, 33, 1928, 383, 99, 983, 1, 34, 2, 345, 9383, 37, 4877, 22, 3748, 999, 9, 90, 232, 11, 13, 31 };

            int c = arr.Length;
            Console.WriteLine("Original Length " + c);

            int[] tempArr = arr.OrderBy(e => e).ToArray();

            int c2 = arr.Length;
            Console.WriteLine("Temp Length " + c2);

            foreach (int i in tempArr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            int target = ReadNumber("Enter The Target Number?");
            int result = BinarySearch(tempArr,target);

            if (result == -1)
                Console.WriteLine("Target Was Not Found!");
            else
                Console.WriteLine($"Target Was Found At Index {result}");


                Console.ReadKey();
        }
    }
}
