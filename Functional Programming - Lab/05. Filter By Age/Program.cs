using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] peopleAndTheirAge = Console.ReadLine()
                    .Split(", ");
                string name = peopleAndTheirAge[0];
                int age = int.Parse(peopleAndTheirAge[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int ageLimit = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = Filter(condition, ageLimit);
            List<Person> matchingPeople = people.Where(filter).ToList();
            Action<Person> formatter = Format(format);

            PrintFilteredPeople(matchingPeople,formatter);  

        }

        private static void PrintFilteredPeople(List<Person> people, Action<Person> formatter)
        {
            foreach (var person in people)
            {
                formatter(person);
            }
        }

        public static Func<Person, bool> Filter(string condition, int age)
        {
            if (condition == "younger")
            {
                return x => x.Age < age;
            }

            else if (condition == "older")
            {
                return x => x.Age >= age;
            }

            return null;
        }

        public static Action<Person> Format(string format)
        {
            if (format == "name")
            {
                return person => Console.WriteLine($"{person.Name}");
            }

            else if (format == "age")
            {
                return person => Console.WriteLine($"{person.Age}");
            }

            else if (format == "name age")
            {
                return person => Console.WriteLine($"{person.Name} - {person.Age}");
            }

            return null;
        }

        public class Person
        {
            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
