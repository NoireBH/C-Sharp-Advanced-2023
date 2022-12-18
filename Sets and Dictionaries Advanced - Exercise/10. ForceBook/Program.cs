using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var forceSidesAndTheirUsers = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                bool splitByLine = false;
                bool splitByArrow = false;
                var cmdSplitByLine = input.Split(" | ");
                var cmdSplitByArrow = input.Split(" -> ");

                if (cmdSplitByLine.Length == 2)
                {
                    splitByLine = true;
                }
                    
                else if (cmdSplitByArrow.Length == 2)
                {
                    splitByArrow = true;
                }
                    

                if (splitByLine)
                {
                    string forceSide = cmdSplitByLine[0];
                    string forceUser = cmdSplitByLine[1];
                    bool containsUser = false;

                    foreach (var team in forceSidesAndTheirUsers)
                    {
                        if (team.Value.Contains(forceUser))
                            containsUser = true;
                    }

                    if (!forceSidesAndTheirUsers.ContainsKey(forceSide))
                    {
                        forceSidesAndTheirUsers.Add(forceSide, new List<string>());

                        if (!containsUser)
                        {
                            forceSidesAndTheirUsers[forceSide].Add(forceUser);
                        }

                    }

                    else
                    {   
                        if (!containsUser)
                        {
                            forceSidesAndTheirUsers[forceSide].Add(forceUser);
                        }
                    }

                    


                }

                else if (splitByArrow)
                {                    
                    string forceUser = cmdSplitByArrow[0];
                    string forceSide = cmdSplitByArrow[1];

                    foreach (var sides in forceSidesAndTheirUsers)
                    {
                        if (sides.Value.Contains(forceUser))
                        {
                            sides.Value.Remove(forceUser);
                            
                        }
                    }

                    if (!forceSidesAndTheirUsers.ContainsKey(forceSide))
                    {
                        forceSidesAndTheirUsers.Add(forceSide, new List<string>());
                    }

                    forceSidesAndTheirUsers[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }

            }

            foreach (var (forceSide,forceUsers) in forceSidesAndTheirUsers
                .Where(users => users.Value.Count > 0)
                .OrderByDescending(users => users.Value.Count)
                .ThenBy(users => users.Key))
            {
                Console.WriteLine($"Side: {forceSide}, Members: {forceUsers.Count}");

                foreach (var user in forceUsers.OrderBy(name => name))
                {
                    Console.WriteLine($"! {user}");
                }
            }

        }
    }
}
