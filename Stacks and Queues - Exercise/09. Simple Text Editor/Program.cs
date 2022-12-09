using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            var text = new StringBuilder();
            var textHistory = new Stack<string>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                string[] cmd = Console.ReadLine()
                    .Split();
                int command = int.Parse(cmd[0]);

                if (command == 4)
                {
                    text = new StringBuilder(textHistory.Pop());
                }

                else
                {


                    if (command == 1)
                    {
                        textHistory.Push(text.ToString());
                        string arguement = cmd[1];
                        text.Append(arguement);

                    }

                    else if (command == 2)
                    {
                        textHistory.Push(text.ToString());
                        int count = int.Parse(cmd[1]);
                        text.Remove(text.Length - count, count);

                    }

                    else if (command == 3)
                    {
                        int index = int.Parse(cmd[1]);
                        Console.WriteLine(text[index - 1]);
                    }

                }
            }
        }
    }
}
