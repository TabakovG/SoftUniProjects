using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                List<string> token = command.Split().ToList();
                int index;
                switch (token[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(token[1]));
                        break;
                    case "Insert":
                        index = int.Parse(token[2]);
                        if (index < numbers.Count && index >= 0)
                        {
                            numbers.Insert(index, int.Parse(token[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        index = int.Parse(token[1]);
                        if (index < numbers.Count && index >= 0)
                        {
                            numbers.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        if (numbers.Count > 0)
                        {
                            if (token[1] == "left")
                            {
                                for (int i = 0; i < int.Parse(token[2]); i++)
                                {
                                    int firstNum = numbers[0];
                                    numbers.RemoveAt(0);
                                    numbers.Add(firstNum);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < int.Parse(token[2]); i++)
                                {
                                    int lastNum = numbers[numbers.Count - 1];
                                    numbers.RemoveAt(numbers.Count - 1);
                                    numbers.Insert(0, lastNum);
                                }
                            }
                        }
                        
                        break;

                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
