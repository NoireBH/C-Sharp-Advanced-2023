using System;

namespace _07._N_Choose_K_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(GetCount(n,k));
        }

        private static int GetCount(int row,int col)
        {
            if (row <= 1 || col == 0 || col == row)
            {
                return 1;
            }

          return  GetCount(row - 1, col - 1) + GetCount(row - 1, col);
        }
    }
}
