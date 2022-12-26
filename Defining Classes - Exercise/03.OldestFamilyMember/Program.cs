using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {   
            Family family = new Family();
            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                int age = int.Parse(parts[1]);
                Person person = new Person(name,age);
                family.AddMember(person);
            }

            Person oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
