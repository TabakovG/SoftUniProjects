using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            if (size <= 0)
            {
                return;
            }
            int[] field = new int[size];
            int[] bugs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            for (int i = 0; i < bugs.Length; i++)
            {
                int bugIndex = bugs[i];
                if (bugIndex >= 0 && bugIndex < field.Length)
                {
                    field[bugIndex] = 1;
                }
            }

            while (command != "end")
            {
                string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                int actionIndex = int.Parse(commandArray[0]);
                string direction = commandArray[1];
                int move = int.Parse(commandArray[2]);

                if (actionIndex >= 0 && actionIndex < field.Length && field[actionIndex] == 1 && move != 0)
                {
                    field[actionIndex] = 0;
                    if (direction == "left")
                    {
                        move *= -1;
                    }
                    int newBugIndex = actionIndex + move;
                    while (newBugIndex >= 0 && newBugIndex < field.Length)
                    {
                        if (field[newBugIndex] == 0)
                        {
                            field[newBugIndex] = 1;
                            break;
                        }
                        else
                        {
                            newBugIndex += move;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
