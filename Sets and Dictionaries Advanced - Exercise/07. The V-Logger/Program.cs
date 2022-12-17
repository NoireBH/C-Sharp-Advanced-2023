using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> VLoggerDatabase = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input;
            while ((input = Console.ReadLine())!= "Statistics")
            {
                string[] parts = input.Split();

                string nameOfVlogger = parts[0];
                string command = parts[1];

                if (command == "joined")
                {
                    if (!VLoggerDatabase.ContainsKey(nameOfVlogger))
                    {
                        VLoggerDatabase.Add(nameOfVlogger, new Dictionary<string, HashSet<string>>());
                        VLoggerDatabase[nameOfVlogger].Add("followers", new HashSet<string>());
                        VLoggerDatabase[nameOfVlogger].Add("following", new HashSet<string>());
                    }
                }

                else if (command == "followed")
                {
                    string member = parts[2];

                    if (nameOfVlogger != member && VLoggerDatabase.ContainsKey(nameOfVlogger) && VLoggerDatabase.ContainsKey(member))
                    {
                        VLoggerDatabase[nameOfVlogger]["following"].Add(member);
                        VLoggerDatabase[member]["followers"].Add(nameOfVlogger);
                    }


                }               
            }

            Console.WriteLine($"The V-Logger has a total of {VLoggerDatabase.Count} vloggers in its logs.");

            int number = 1;

            foreach (var vlogger in VLoggerDatabase.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{number}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (number == 1)
                {
                    foreach (string follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                number++;
            }
        }
    }
}
