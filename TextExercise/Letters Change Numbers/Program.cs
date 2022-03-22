using System;

namespace Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new string[] {" ", "\t"  }, StringSplitOptions.RemoveEmptyEntries);

            decimal sumTotal = 0;

            foreach (string item in input)
            {
                char beforeNum = item[0];
                char afterNum = item[item.Length-1];
                decimal num = decimal.Parse(item.Substring(1, item.Length-2));
                decimal sum = 0;

                if (char.IsUpper(beforeNum))
                {
                    sum += Math.Round((num / ((int)beforeNum - 64)), 2);
                }
                else if (char.IsLower(beforeNum))
                {
                    sum += num * ((int)beforeNum - 96);
                }
                if (char.IsUpper(afterNum))
                {
                    sum -= ((int)afterNum - 64);
                }
                else if (char.IsLower(afterNum))
                {
                    sum += ((int)afterNum - 96);
                }

                sumTotal += sum;
                
            }

            Console.WriteLine($"{sumTotal:f2}");
        }
    }
}
