using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class ErrorMsg
    {
        public const string InvalidDough = "Invalid type of dough.";
        public const string InvalidWeight = "Dough weight should be in the range [1..200].";
        public const string InvalidToppingWeight = "{0} weight should be in the range [1..50].";
        public const string InvalidToping = "Cannot place {0} on top of your pizza.";
        public const string InvalidPizzaName = "Pizza name should be between 1 and 15 symbols.";
        public const string InvalidToppingCount = "Number of toppings should be in range [0..10].";
    }
}
