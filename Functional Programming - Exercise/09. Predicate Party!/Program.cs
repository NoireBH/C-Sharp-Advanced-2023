using System;
using System.Collections.Generic;
using System.Linq;


namespace _09._Predicate_Party_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> partyPeople = Console.ReadLine().Split()
                .ToList();

            string input;
            while ((input = Console.ReadLine())!= "Party!")
            {
                string[] parts = input.Split();
                string command = parts[0];

                Predicate<string> searcher = GetCondition(input);

                if (command == "Remove")
                {
                    partyPeople.RemoveAll(searcher);
                }

                else if (command == "Double")
                {

                    for (int i = 0; i < partyPeople.Count; i++)
                    {
                        string person = partyPeople[i];

                        if (searcher(person))
                        {
                            partyPeople.Insert(i + 1, person);
                            i++;
                        }
                        
                    }                   
                }                
            }

            if (partyPeople.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }

            else
            {
                Console.WriteLine(String.Join(", ", partyPeople) + " are going to the party!");
            }
        }

        public static Predicate<string> GetCondition(string command)
        {
            Predicate<string> searcher = null;
            string[] arg = command.Split();
            string cmd = arg[1];
            string lettersToCheck = arg[2];

            if (cmd == "StartsWith")
            {
                searcher = name => name.StartsWith(lettersToCheck);
            }

            else if (cmd == "EndsWith")
            {
                searcher = name => name.EndsWith(lettersToCheck);
            }

            else if (cmd == "Length")
            {
                searcher = name => name.Length == int.Parse(lettersToCheck);
            }

            return searcher;
        }
    }
}
