
namespace PizzaCalories
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            try
            {
                string pizzaName = Console.ReadLine().Split(" ")[1];

                string[] doughInfo = Console.ReadLine().Split(' ');
                var dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
                var pizza = new Pizza(pizzaName, dough);

                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] toppingInfo = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    var topping = new Topping(toppingInfo[1], double.Parse(toppingInfo[2]));
                    pizza.AddTopping(topping);

                    input = Console.ReadLine();
                }
                Console.WriteLine($"{pizzaName} - {pizza.TotalCalories:f2} Calories.");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }
    }
}
