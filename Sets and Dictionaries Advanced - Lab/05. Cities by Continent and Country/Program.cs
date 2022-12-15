using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var citiesByContinentAndCountry = new Dictionary<string, Dictionary<string, List<string>>>();
            int countOfCountries = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCountries; i++)
            {
                string[] continentsAndCountries = Console.ReadLine().Split();
                string continent = continentsAndCountries[0];
                string country = continentsAndCountries[1];
                string cities = continentsAndCountries[2];

                if (!citiesByContinentAndCountry.ContainsKey(continent))
                {
                    citiesByContinentAndCountry[continent] = new Dictionary<string, List<string>>();

                   
                    
                }

                if (!citiesByContinentAndCountry[continent].ContainsKey(country))
                {
                    citiesByContinentAndCountry[continent].Add(country, new List<string>());
                    citiesByContinentAndCountry[continent][country].Add(cities);
                }

                else
                {
                    citiesByContinentAndCountry[continent][country].Add(cities);

                }
            }


            foreach (var continent in citiesByContinentAndCountry)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"   {country.Key} -> {string.Join(", ",country.Value)}");

                }
            }
        }
    }
}
