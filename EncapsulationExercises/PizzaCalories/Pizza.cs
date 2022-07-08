using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private readonly List<Topping> toppings;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                {
                    throw new ArgumentException(ErrorMsg.InvalidPizzaName);
                }
                this.name = value;
            }
        }

        public Dough Dough
        {
            get { return this.dough; }
            set { this.dough = value; }
        }
        public int NumberOfToppings => this.toppings.Count;
        public double TotalCalories
        {
            get
            {
                double sum = 0;
                foreach (var topping in this.toppings)
                {
                    sum += topping.Calories;
                }
                return this.dough.Calories + sum;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.NumberOfToppings == 10)
            {
                throw new ArgumentException(ErrorMsg.InvalidToppingCount);
            }
            this.toppings.Add(topping);
        }

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }    
    }
}
