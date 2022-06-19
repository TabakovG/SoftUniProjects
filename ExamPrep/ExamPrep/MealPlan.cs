using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPrep
{
    internal class MealPlan
    {
        static void Main(string[] args)
        {
            var meals = new Queue<string>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries));
            var calPerDay = new Stack<int>(
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var mealTable = new Dictionary<string, int>()
            {
                { "salad", 350},
                { "soup", 490},
                { "pasta", 680},
                { "steak", 790}
            };
            int numMeals = 0;

            while (meals.Count > 0)
            {
                string eat = meals.Dequeue();
                numMeals++;
                int mealCals = mealTable.Where(x => x.Key == eat).First().Value;

                if (calPerDay.Count > 0)
                {
                    int calsPermitted = calPerDay.Pop();

                    int result = calsPermitted - mealCals;
                    if (result > 0)
                        calPerDay.Push(result);
                    else
                    {
                        if (calPerDay.Count > 0)
                        {
                            int decreaseFromNext = calPerDay.Pop() + result;
                            calPerDay.Push(decreaseFromNext);
                        }
                        else
                        {
                            Console.WriteLine($"John ate enough, he had {numMeals} meals.");
                            Console.WriteLine($"Meals left: {String.Join(", ", meals)}.");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine($"John had {numMeals} meals.");
            Console.WriteLine($"For the next few days, he can eat {string.Join(", ", calPerDay)} calories.");
        }
    }
}
