using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {   
                string[] cmd = input.Split(", ");
                string number = cmd[0];
                char firstChar = number[0];
                

                if (Char.IsDigit(firstChar) && number.Length == 8)
                {
                    VIP.Add(number);
                }

                else if (!Char.IsDigit(firstChar) && number.Length == 8)
                {
                    regular.Add(number);
                }              
            }


            while ((input = Console.ReadLine()) != "END")
            {
                if (VIP.Contains(input))
                {
                    VIP.Remove(input);
                }

                else if (regular.Contains(input))
                {
                    regular.Remove(input);
                }
            }

            Console.WriteLine(VIP.Count + regular.Count);

            foreach (var vip in VIP)
            {
                Console.WriteLine(vip);
            }

            foreach (var person in regular)
            {
                Console.WriteLine(person);
            }

        }
    }
}