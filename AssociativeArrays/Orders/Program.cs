using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> pList = new Dictionary<string, int>();
            Dictionary<string, decimal> pPrices = new Dictionary<string, decimal>();

            string command = Console.ReadLine();
            while (command != "buy")
            {
                string[] cmd = command.Split();

                if (!pList.ContainsKey(cmd[0]))
                {
                    pList[cmd[0]] = int.Parse(cmd[2]);
                    pPrices[cmd[0]] = decimal.Parse(cmd[1]);
                }
                else
                {
                    pList[cmd[0]] += int.Parse(cmd[2]);
                    pPrices[cmd[0]] = decimal.Parse(cmd[1]);
                }

                command = Console.ReadLine();
            }
            foreach (var item in pList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value*pPrices[item.Key]:f2}");
            }

        }
    }
    
}
