using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinarySearch.Person_Class
{
    /// <summary>
    /// Represents a Person with Name and Age, implementing IComparable for sorting.
    /// </summary>
    public class Person : IComparable<Person>
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Person other)
        {
            if (other == null) return 1;

            int nameCompare = Name.CompareTo(other.Name);
            if (nameCompare != 0) return nameCompare;

            return Age.CompareTo(other.Age);
        }
    }
}
