using System;

namespace _07._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacchi(n)); 
        }

        private static int GetFibonacchi(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }

           return  GetFibonacchi(n - 1) + GetFibonacchi(n - 2);
        }
    }
}
