using System;
using System.Linq;

namespace Stack
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] cmd = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                string command = cmd[0];

                if (command == "Push")
                {
                    string[] itemsToPush = cmd.Skip(1).ToArray();

                    foreach (var item in itemsToPush)
                    {
                        stack.Push(item);
                    }
                }

                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (InvalidOperationException exception)
                    {

                        Console.WriteLine(exception.Message);
                    }
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }


        }
    }
}
