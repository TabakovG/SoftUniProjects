using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    internal class StartUp
    {
        static void Main()
        {
            try
            {
                var persons = new List<Person>();
                string[] personInput = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
                foreach (string prsn in personInput)
                {
                    string[] prsnInfo = prsn.Split("=");
                    persons.Add(new Person(prsnInfo[0], decimal.Parse(prsnInfo[1])));
                }

                var products = new List<Product>();
                string[] productsInput = Console.ReadLine().Split(";",StringSplitOptions.RemoveEmptyEntries);
                foreach (string product in productsInput)
                {
                    string[] prodInfo = product.Split("=");
                    products.Add(new Product(prodInfo[0], decimal.Parse(prodInfo[1])));
                }

                string cmd = Console.ReadLine();
                while (cmd != "END")
                {
                    string[] action = cmd.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    var currentPerson = persons.First(x => x.Name == action[0]);
                    var currentProduct = products.First(x => x.Name == action[1]);

                    Console.WriteLine(currentPerson.BuyProduct(currentProduct));

                    cmd = Console.ReadLine();
                }

                foreach (var person in persons)
                {
                    if (person.Bag.Count > 0)
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag)}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
