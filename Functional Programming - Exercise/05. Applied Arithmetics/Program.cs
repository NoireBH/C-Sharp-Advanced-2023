using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string command = input;

                if (command == "add")
                {
                    Func<List<int>, List<int>> add = numbers => numbers.Select(n => n += 1).ToList();
                    numbers = add(numbers);
                }

                else if (command == "multiply")
                {
                    Func<List<int>, List<int>> multiply = numbers => numbers.Select(n => n *= 2).ToList();
                    numbers = multiply(numbers);
                }

                else if (command == "subtract")
                {
                    Func<List<int>, List<int>> subtract = numbers => numbers.Select(n => n -= 1).ToList();
                    numbers = subtract(numbers);
                }

                else if (command == "print")
                {
                    Action<List<int>> print = numbers => Console.WriteLine(String.Join(" ", numbers));
                    print(numbers);
                }

                else if (command == "end")
                {
                    break;
                }
            }
        }
    }
}
