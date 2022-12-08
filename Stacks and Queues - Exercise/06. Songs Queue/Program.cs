using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");
            var songQueue = new Queue<string>(songs);

            while (songQueue.Count > 0)
            {
                string command = Console.ReadLine();
                

                if (command == "Play")
                {
                    songQueue.Dequeue();
                }

                else if (command.Contains("Add"))
                {
                    string song = command.Substring(4);

                    if (!songQueue.Contains(song))
                    {
                        songQueue.Enqueue(song);
                    }

                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }

                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
