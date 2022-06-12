using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBox
{
    public class StartUp
    {
        static void Main()
        {
            //string version:

            int num = int.Parse(Console.ReadLine());
            var list = new List<double>();
            for (int i = 0; i < num; i++)
            {
                var input = Console.ReadLine();
                list.Add(double.Parse(input));
            }

            /*int[] swapIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();*/


            var box = new GenericBox<double>(list);
            double itemToCompare = double.Parse(Console.ReadLine());
            //box.Swap(list, swapIndexes[0], swapIndexes[1]);
            Console.WriteLine(box.CountOfGreater(list, itemToCompare));

            //int version:

            /*int num = int.Parse(Console.ReadLine());
            List<GenericBox<int>> list = new List<GenericBox<int>>();
            for (int i = 0; i < num; i++)
            {
                var box = new GenericBox<int>(int.Parse(Console.ReadLine()));
                list.Add(box);
            }

            int[] swapIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            GenericMethod(list, swapIndexes[0], swapIndexes[1]);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }*/

            

            


        }
    }
}
