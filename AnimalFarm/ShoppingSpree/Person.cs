using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be empty");
                }
            }
        }
        private decimal money;

        public decimal Money
        {
            get { return this.money; }
            private set
            {
                if (value >= 0)
                {
                    this.money = value;
                }
                else
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }
        private List<Product> bag;

        public IReadOnlyList<Product> Bag
        {
            get { return this.bag.AsReadOnly(); }
        }

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string BuyProduct(Product product)
        {

            if (this.Money >= product.Cost)
            {
                this.bag.Add(product);
                this.Money -= product.Cost;
                return $"{this.Name} bought {product.Name}";
            }
            else
            {
                return $"{this.Name} can't afford {product.Name}";
            }
        }
    }
}
