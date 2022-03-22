using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(repeatStr(input, num));
            
        }

        static string repeatStr(string str, int steps)
        {
            StringBuilder container = new StringBuilder();
            for (int i = 0; i < steps; i++)
            {
                container.Append(str);
            }
            return container.ToString();

        }
    }
}
