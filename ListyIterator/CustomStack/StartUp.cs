using System;
using System.Linq;

namespace CustomStack
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();

            string cmd = Console.ReadLine();
            while (cmd != "END")
            {
                string comm = cmd.Split()[0];
                switch (comm)
                {
                    case "Pop":
                        stack.Pop();
                        break;
                    case "Push":
                        string[] input = cmd.Split(" ");
                        if (input.Length > 1)
                        {
                            int[] elements = cmd.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                                .Skip(1)
                                .Select(int.Parse)
                                .ToArray();
                            stack.Push(elements);
                        }
                        break;
                    default:
                        break;
                }

                cmd = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
