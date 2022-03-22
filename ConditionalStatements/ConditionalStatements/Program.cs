using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();
            // sunny, rainy, snowy, windy
            if (weather == "sunny")
            {
                Console.WriteLine("The weather is nice!");
            }
            else if (weather == "rainy")
            {
                Console.WriteLine("Take an umbrella!");
            }
            else if (weather == "snowy")
            {
                Console.WriteLine("Go skiing");
            }
            else if (weather == "windy")
            {
                Console.WriteLine("Whear a coat!");
            }
            else
            {
                Console.WriteLine("Invalid weather!");
            }
        }
    }
}
