using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Cinema
{
    internal class Program
    {
        private static List<string> names;
        private static string[] seats;
        private static HashSet<int> lockedSeats;

        static void Main(string[] args)
        {
            names = Console.ReadLine()
                .Split(", ")
                .ToList();

            seats = new string[names.Count];
            lockedSeats = new HashSet<int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "generate")
                {
                    break;
                }

                string[] parts = line.Split(" - ");
                string name = parts[0];
                int position = int.Parse(parts[1]) - 1;

                names.Remove(name);
                seats[position] = name;
                lockedSeats.Add(position);
            }

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index >= names.Count)
            {
                Print();
                return;
            }

            Permute(index + 1);

            for (int i = index + 1; i < names.Count; i++)
            {
                Swap(index, i);
                Permute(index + 1);
                Swap(index, i);
            }
        }

        private static void Print()
        {
            var namesIndex = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                if (lockedSeats.Contains(i))
                {
                    continue;
                }

                seats[i] = names[namesIndex++];
                
            }

            Console.WriteLine(string.Join(" ", seats));
        }

        private static void Swap(int first, int second)
        {
            var temp = names[first];
            names[first] = names[second];
            names[second] = temp;
        }
    }
}
