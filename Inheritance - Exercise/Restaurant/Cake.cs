using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double DefGrams = 250;
        private const double DefCalories = 1000;
        private const decimal DefPrice = 5;

        public Cake(string name) : base(name, DefPrice, DefGrams, DefCalories)
        {

        }
    }
}
