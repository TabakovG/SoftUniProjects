using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const double BaseCalories = 2;

        private const double Meat = 1.2;
        private const double Veggies = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9;

        private string toppingType;
        private double weight;
        private double toppingModifier;
        internal double Calories { get => this.toppingModifier * BaseCalories * this.Weight; }

        private string ToppingType
        {
            get 
            { 
                return this.toppingType; 
            }
            set
            {
                string valueCheck = value.ToString().ToLower();
                if (valueCheck != "meat" && valueCheck != "veggies" && valueCheck != "cheese" && valueCheck != "sauce")
                {
                    throw new ArgumentException(String.Format(ErrorMsg.InvalidToping, value));
                }
                this.toppingType = value[0].ToString().ToUpper() + value.Substring(1);
            }
        }
        private double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException(String.Format(ErrorMsg.InvalidToppingWeight, this.toppingType));
                }
                this.weight = value;
            }
        }

        public Topping(string toppingType, double weight)
        {
            this.ToppingType = toppingType;
            this.Weight = weight;

            this.toppingModifier = this.toppingType == "Meat" ? Meat :
                                   this.toppingType == "Veggies" ? Veggies :
                                   this.toppingType == "Cheese" ? Cheese : Sauce;
        }
    }
}
