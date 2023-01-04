using System;

namespace Tuple
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var tuple1 = new Tuple<string, string>();
            var tuple2 = new Tuple<string, int>();
            var tuple3 = new Tuple<int, double>();
            string[] nameAndAdress = Console.ReadLine().Split();

            string firstName = nameAndAdress[0];
            string lastName = nameAndAdress[1];
            string adress = nameAndAdress[2];
            tuple1.Item1 = firstName + " " + lastName;
            tuple1.Item2 = adress;

            string[] nameAndBeerAmount = Console.ReadLine().Split();

            string secondPersonFirstName = nameAndBeerAmount[0];
            int beerAmount = int.Parse(nameAndBeerAmount[1]);
            tuple2.Item1 = secondPersonFirstName;
            tuple2.Item2 = beerAmount;

            string[] IntAndDouble = Console.ReadLine().Split();
            int integer = int.Parse(IntAndDouble[0]);
            double doubleNum = double.Parse(IntAndDouble[1]);
            tuple3.Item1 = integer;
            tuple3.Item2 = doubleNum;



            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);

        }
    }
}
