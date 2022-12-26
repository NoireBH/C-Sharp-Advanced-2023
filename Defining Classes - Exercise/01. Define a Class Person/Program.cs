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

            Console.WriteLine(person.Age);
            Console.WriteLine(person.Name);
        }
    }
}
