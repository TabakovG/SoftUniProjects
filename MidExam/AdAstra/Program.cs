using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separators = { "#|", "##", "|#", "||" };
            List<string> decodedInput = Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] subSeparators = { "#", "|" };
            List<string> foodName = new List<string>();
            List<string> foodDate = new List<string>();
            List<int> foodKcal = new List<int>();
            for (int i = 0; i < decodedInput.Count; i++)
            {
                string[] itemValues = decodedInput[i].Split(subSeparators, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (itemValues.Length == 3 && isNameValid(itemValues[0]) && isDateValid(itemValues[1]) && areNutrValid(itemValues[2]))
                {
                    foodName.Add(itemValues[0]);
                    foodDate.Add(itemValues[1]);
                    foodKcal.Add(int.Parse(itemValues[2]));

                }
            }
            Console.WriteLine($"You have food to last you for: {foodKcal.Sum() / 2000} days!");
            for (int j = 0; j < foodName.Count; j++)
            {
                Console.WriteLine($"Item: {foodName[j]}, Best before: {foodDate[j]}, Nutrition: {foodKcal[j]}");
            }
        }
        static bool isNameValid(string itemName)
        {
            foreach (char item in itemName)
            {
                if (!Char.IsLetter(item))
                {
                    if (!Char.IsWhiteSpace(item))
                    {
                        return false;

                    }
                }
            }
            return true;
        }
        static bool isDateValid(string date)
        {
            string[] dateArr = date.Split('/', StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in dateArr)
            {
                if (item.Length != 2)
                {
                    return false;
                }
                foreach (char ch in item)
                {
                    if (!Char.IsDigit(ch))
                    {
                        return false;
                    }
                }

            }
            return true;
        }
        static bool areNutrValid(string nutritions)
        {
            if (int.TryParse(nutritions, out int result))
            {
                if (result >= 0 && result < 10001)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
