using System;

namespace _02._Recursive_Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDrawings = int.Parse(Console.ReadLine());
            PrintDrawing(numberOfDrawings);
        }

        public static void PrintDrawing(int n)
        {
            if (n <= 0)
            {
                return;
            }

            Console.WriteLine(new string('*', n));
            PrintDrawing(n - 1);
            Console.WriteLine(new String('#',n));
        }
    }
}
