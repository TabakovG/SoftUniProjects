using System;
using System.Linq;

namespace AddVAT
{
    internal class AddVAT
    {
        static void Main()
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();
            Func<double, string> addVat = x => (x * 1.2).ToString("f2");
            Console.WriteLine(String.Join(Environment.NewLine, prices.Select(addVat)));
        }
    }
}
