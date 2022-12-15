using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shopAndProducts = new Dictionary<string, Dictionary<string, double>>();

            string input;
            while ((input = Console.ReadLine())!= "Revision")
            {
                string[] cmd = input.Split(", ");
                string shop = cmd[0];
                string product = cmd[1];
                double price = double.Parse(cmd[2]);

                if (!shopAndProducts.ContainsKey(shop))
                {
                    shopAndProducts[shop] = new Dictionary<string, double>();
                    shopAndProducts[shop].Add(product, price);
                }

                else
                {

                    shopAndProducts[shop].Add(product, price);
                }
                                 
            }

            foreach (var shop in shopAndProducts.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }

        }
    }
}
