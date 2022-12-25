using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._The_Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> peopleInvitedToParty = Console.ReadLine().Split()
                .ToList();
            var filters = new Dictionary<string, Predicate<string>>();

            string input;
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] parts = input.Split(";");
                string command = parts[0];
                


                if (command == "Add filter")
                {
                    filters.Add(parts[1] + parts[2], Filter(input));
                }

                else if (command == "Remove filter")
                {
                    filters.Remove(parts[1] + parts[2]);
                }
            }

            foreach (var filter in filters)
            {
                peopleInvitedToParty.RemoveAll(filter.Value);
            }

            Console.WriteLine(String.Join(" ", peopleInvitedToParty));
        }

        public static Predicate<string> Filter(string input)
        {
            Predicate<string> filter = null;
            string[] command = input.Split(";");
            string typeOfFilter = command[1];
            string arguementForFilter = command[2];

            if (typeOfFilter == "Starts with")
            {
                filter = name => name.StartsWith(arguementForFilter);
            }

            else if (typeOfFilter == "Ends with")
            {
                filter = name => name.EndsWith(arguementForFilter);
            }

            else if (typeOfFilter == "Length")
            {
                filter = name => name.Length == int.Parse(arguementForFilter);
            }

            else if (typeOfFilter == "Contains")
            {
                filter = name => name.Contains(arguementForFilter);
            }

            return filter;
        }
    }
}
