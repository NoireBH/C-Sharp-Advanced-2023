using System;

namespace CustomStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.ForEach(x => Console.WriteLine(x));
            stack.Clear();
            stack.ForEach(x => Console.WriteLine(x));

        }
    }
}
