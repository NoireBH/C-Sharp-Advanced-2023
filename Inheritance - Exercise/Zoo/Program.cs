using System;

namespace Zoo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Lizard lizard = new Lizard("Gosho");
            Gorilla gorilla = new Gorilla("Pesho");

            Console.WriteLine(lizard.Name);
            Console.WriteLine(gorilla.Name);
            
        }
    }
}
