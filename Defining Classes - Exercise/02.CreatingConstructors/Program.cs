using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Peter",
                Age = 20
            };

            Person person2 = new Person(13);
            Person person3 = new Person("Gosho",20);

            Console.WriteLine(person.Age);
            Console.WriteLine(person.Name);
            Console.WriteLine($"{person2.Name} : {person2.Age}");
            Console.WriteLine($"{person3.Name} : {person3.Age}");
        }
    }
}
