using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] parts = input.Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string town = parts[2];
                Person person = new Person(name,age,town);
                people.Add(person);
            }

            int indexOfPerson = int.Parse(Console.ReadLine());
            Person personToCompare = people[indexOfPerson - 1];
            int matches = 0;
            int unmatchedPeople = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    matches++;
                }

                else
                {
                    unmatchedPeople++;
                }
            }

            if (matches == 1)
            {
                Console.WriteLine("No matches");
            }

            else
            {
                Console.WriteLine($"{matches} {unmatchedPeople} {people.Count}");
            }
        }
    }
}