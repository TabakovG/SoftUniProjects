using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (token[0])
                {
                    case "Urgent":
                        string item = token[1];
                        if (!shoppingList.Contains(item))
                        {
                            shoppingList.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        string itemToRemove = token[1];
                        if (shoppingList.Contains(itemToRemove))
                        {
                            shoppingList.Remove(itemToRemove);
                        }
                        break;
                    case "Correct":
                        string oldItem = token[1];
                        string newItem = token[2];
                        if (shoppingList.Contains(oldItem))
                        {
                            int index = shoppingList.IndexOf(oldItem);
                            shoppingList[index] = newItem;
                        }
                        break;
                    case "Rearrange":
                        string grocery = token[1];
                        if (shoppingList.Contains(grocery))
                        {
                            int index = shoppingList.IndexOf(grocery);
                            shoppingList.Add(shoppingList[index]);
                            shoppingList.RemoveAt(index);
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
