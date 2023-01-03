using System;

namespace GenericArrayCreator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Georgi");
            int[] integers = ArrayCreator.Create(10, 10);

            Console.WriteLine(string.Join(" ", strings));
            Console.WriteLine(string.Join(" ", integers));
        }
    }
}
