using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> personInSet = new HashSet<Person>();
            SortedSet<Person> personInSortedSet = new SortedSet<Person>();

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                personInSet.Add(new Person(name, age));
                personInSortedSet.Add(new Person(name, age));
            }

            Console.WriteLine(personInSet.Count);
            Console.WriteLine(personInSortedSet.Count);
        }
    }
}
