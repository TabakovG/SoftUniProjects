using System;

namespace FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {

                string[] cmd = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];

                switch (action)
                {
                    case "Change":
                        string ch = cmd[1];
                        string replacement = cmd[2];

                        input = input.Replace(ch, replacement);
                        Console.WriteLine(input);
                        break;
                    case "Includes":
                        string substring = cmd[1];
                        if (input.Contains(substring))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "End":

                        string substr = cmd[1];
                        if (input.EndsWith(substr))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Uppercase":
                        input = input.ToUpper();
                        Console.WriteLine(input);
                        break;
                    case "FindIndex":
                        string indexOf = cmd[1];
                        int index = input.IndexOf(indexOf);
                        Console.WriteLine(index);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(cmd[1]);
                        int count = int.Parse(cmd[2]);
                        input = input.Substring(startIndex, count);
                        Console.WriteLine(input);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
