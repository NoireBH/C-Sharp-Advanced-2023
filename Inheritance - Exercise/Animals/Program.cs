using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string typeOfAnimal;
            while ((typeOfAnimal = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    string[] animalInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string name = animalInfo[0];
                    int age = int.Parse(animalInfo[1]);

                    Animal animal = null;

                    if (typeOfAnimal == "Dog")
                    {
                        string gender = animalInfo[2];
                        animal = new Dog(name, age, gender);
                    }

                    else if (typeOfAnimal == "Frog")
                    {
                        string gender = animalInfo[2];
                        animal = new Frog(name, age, gender);
                    }

                    else if (typeOfAnimal == "Cat")
                    {
                        string gender = animalInfo[2];
                        animal = new Cat(name, age, gender);
                    }

                    else if (typeOfAnimal == "Kitten")
                    {
                        animal = new Kitten(name, age);
                    }

                    else if (typeOfAnimal == "Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }

                    else
                    {
                        throw new InvalidOperationException("Invalid input!");
                    }

                    animals.Add(animal);
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid input!");
                }

                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.ToString());
                }
                
            }
        }
    }
}
