﻿using System;

namespace GenericBoxofString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string item = Console.ReadLine();
                box.Items.Add(item);
            }

            Console.WriteLine(box);
        }
    }
}
