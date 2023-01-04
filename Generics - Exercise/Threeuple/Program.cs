using System;

namespace Threeuple
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var tuple1 = new Tuple<string, string,string>();
            var tuple2 = new Tuple<string, int,bool>();
            var tuple3 = new Tuple<string, double, string>();
            string[] nameAndAdress = Console.ReadLine().Split();

            string firstName = nameAndAdress[0];
            string lastName = nameAndAdress[1];
            string adress = nameAndAdress[2];
            string town = nameAndAdress[3];
            if (nameAndAdress.Length == 5)
            {
                 town = nameAndAdress[3] + " " + nameAndAdress[4];
            }
            
            tuple1.Item1 = firstName + " " + lastName;
            tuple1.Item2 = adress;
            tuple1.Item3 = town;

            string[] personAndBeer = Console.ReadLine().Split();

            string secondPersonFirstName = personAndBeer[0];
            int beerAmount = int.Parse(personAndBeer[1]);
            tuple2.Item1 = secondPersonFirstName;
            tuple2.Item2 = beerAmount;
            tuple2.Item3 = personAndBeer[2] == "drunk";
                 
            string[] bankAccount = Console.ReadLine().Split();
            string name = bankAccount[0];
            double balance = double.Parse(bankAccount[1]);
            string nameOfBank = bankAccount[2];
            tuple3.Item1 = name;
            tuple3.Item2 = balance;
            tuple3.Item3 = nameOfBank;



            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
    }
}
