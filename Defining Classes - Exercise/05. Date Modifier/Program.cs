using System;

namespace DataModifier
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var dateDifference = new DateModifier();

            Console.WriteLine(dateDifference.GetDifferenceInDays(firstDate, secondDate));
        }
    }
}
