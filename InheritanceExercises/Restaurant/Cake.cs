using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        public Cake(string name) 
            : base(name, CakePrice, CakeGrams, CakeCalories)
        {
        }
        const double CakeGrams = 250;
        const double CakeCalories = 1000;
        const decimal CakePrice = 5;
    }
}
