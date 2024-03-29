﻿using System;

namespace GenericCountMethodDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int elementsToAdd = int.Parse(Console.ReadLine());

            for (int i = 0; i < elementsToAdd; i++)
            {
                double elementToAdd = double.Parse(Console.ReadLine());
                box.Items.Add(elementToAdd);
            }

            double elementToCompareTo = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Count(box.Items, elementToCompareTo));
        }
    }
}
