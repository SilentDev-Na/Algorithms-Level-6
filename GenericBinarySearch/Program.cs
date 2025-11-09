using GenericBinarySearch.Person_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using static GenericBinarySearch.Helper.Helper;

namespace GenericBinarySearch
{
    internal class Program
    {
        /// <summary>
        /// Performs binary search on an integer array.
        /// </summary>
        static int BinarySearch(int[] arr, int target)
        {
            int start = 0, end = arr.Length - 1;
            int trialCount = 0;

            while (start <= end)
            {
                int middle = start + (end - start) / 2;
                trialCount++;
                Console.WriteLine("Trial = " + trialCount);

                if (arr[middle] == target)
                    return middle;

                if (target > arr[middle])
                    start = middle + 1;
                else
                    end = middle - 1;
            }

            return -1;
        }

        /// <summary>
        /// Performs generic binary search on a List of any IComparable type.
        /// </summary>
        static int BinarySearch<T>(List<T> list, T target) where T : IComparable<T>
        {
            int start = 0, end = list.Count - 1;

            while (start <= end)
            {
                int middle = start + (end - start) / 2;
                int compareResult = target.CompareTo(list[middle]);

                if (compareResult == 0)
                    return middle;

                if (compareResult > 0)
                    start = middle + 1;
                else
                    end = middle - 1;
            }

            return -1;
        }

        static void Main(string[] args)
        {
            // ===== Initialize Lists =====
            List<int> numbersList = new List<int> { 2, 1, 44, 33, 455, 6, 6665, 434, 56, 53, 6, 78, 7, 654, 22, 21, 90, 88, 12 };
            List<string> namesList = new List<string> { "Naji", "Ahmed", "Ali", "Dina", "Ibrahim", "Danial", "Jaber", "Luna" };
            List<Person> personsList = new List<Person>
            {
                new Person("Naji Hamed", 26),
                new Person("Ahmed Amman", 26),
                new Person("Ali Jaber", 29),
                new Person("Dina Saad", 30)
            };

            // ===== Sort Lists =====
            personsList.Sort();
            numbersList.Sort();
            namesList.Sort();

            // ===== Search in object list =====

           // SearchPersonTarget(personsList);

            // ===== Search in integer list =====
            //Comment Out To See The Results 
           // SearchIntegerTarget(numbersList);

            // ===== Search in string list =====
            SearchStringTarget(namesList);

            Console.ReadKey();
        }

        /// <summary>
        /// Prompts the user to search for a target integer in the list and prints the arrow.
        /// </summary>
        static void SearchIntegerTarget(List<int> numbers)
        {
            Console.WriteLine("\nNumbers List:");
            Console.WriteLine(string.Join(" ", numbers));

            int targetNumber = ReadValue<int>("Please Enter The Target Number?:");
            int numberIndex = BinarySearch(numbers, targetNumber);

            if (numberIndex == -1)
            {
                Console.WriteLine($"{targetNumber} Was NOT Found!");
            }
            else
            {
                Console.WriteLine($"{targetNumber} Was Found At Index {numberIndex}");
                Console.WriteLine(string.Join(" ", numbers));
                string arrowLine = PrintArrow(numbers, numberIndex);
                Console.WriteLine(arrowLine);
            }
        }

        /// <summary>
        /// Prompts the user to search for a target string in the list and prints the arrow.
        /// </summary>
        static void SearchStringTarget(List<string> names)
        {
            Console.WriteLine("\nNames List:");
            Console.WriteLine(string.Join(" ", names));

            string targetName = ReadValue<string>("\nEnter The Target Name?:");
            int nameIndex = BinarySearch(names, targetName);

            if (nameIndex == -1)
            {
                Console.WriteLine($"\n{targetName} Was NOT Found!");
            }
            else
            {
                Console.WriteLine($"{targetName} Was Found At Index {nameIndex}");
                Console.WriteLine(string.Join(" ", names));
                string arrowLine = PrintArrow(names, nameIndex);
                Console.WriteLine(arrowLine);
            }
        }
        static void SearchPersonTarget(List<Person> person)
        {
            foreach (Person p in person)
            {
                Console.WriteLine("Person: " + p.Name + " " + p.Age);
            }

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ===== Search for a specific person =====
            Person targetPerson = new Person(ReadValue<string>("\nEnter Person Name?:"), ReadValue<int>("\nEnter Person Age?:"));

            int personIndex = BinarySearch(person, targetPerson);

            if (personIndex == -1)
                Console.WriteLine($"\n{targetPerson.Name} {targetPerson.Age} Was NOT Found!");
            else
                Console.WriteLine($"\n{targetPerson.Name} {targetPerson.Age} Was Found!");
        }
    }

}

