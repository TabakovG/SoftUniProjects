using System;
using System.Linq;

namespace Phones
{
    public class StartUp
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] sites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var smartphone = new Smartphone();
            var phone = new StationaryPhone();

            foreach (var number in numbers)
            {
                if (number.Length == 7)
                {
                    Console.WriteLine(phone.Call(number)); 
                }
                else if (number.Length == 10)
                {
                    Console.WriteLine(smartphone.Call(number));
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            foreach (var site in sites)
            {
                if (site.Any(c=>char.IsDigit(c)))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                Console.WriteLine(smartphone.Browse(site));
            }
        }
    }
}
