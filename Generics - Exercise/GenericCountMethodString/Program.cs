using System;

namespace GenericCountMethodString
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int elementsToAdd = int.Parse(Console.ReadLine());

            for (int i = 0; i < elementsToAdd; i++)
            {
                string elementToAdd = Console.ReadLine();
                box.Items.Add(elementToAdd);
            }

            string elementToCompareTo = Console.ReadLine();

            Console.WriteLine(box.Count(box.Items, elementToCompareTo));
        }
    }
}
