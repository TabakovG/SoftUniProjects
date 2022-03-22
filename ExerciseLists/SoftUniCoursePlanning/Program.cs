using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> softUniC = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                List<string> token = command.Split(":").ToList();
                switch (token[0])
                {
                    case "Add":
                        if (!softUniC.Contains(token[1]))
                        {
                            softUniC.Add(token[1]);
                        }
                        break;
                    case "Insert":
                        if (!softUniC.Contains(token[1]))
                        {
                            softUniC.Insert(int.Parse(token[2]), token[1]);
                        }
                        break;
                    case "Remove":
                        if (softUniC.Contains(token[1]))
                        {
                            softUniC.Remove(token[1]);
                            if (softUniC.Contains($"{token[1]}-Exercise"))
                            {
                                softUniC.Remove($"{token[1]}-Exercise");
                            }
                        }
                        break;
                    case "Swap":
                        if (softUniC.Contains(token[1]) && softUniC.Contains(token[2]))
                        {
                            int indexFirstC = softUniC.IndexOf(token[1]);
                            int indexSecondC = softUniC.IndexOf(token[2]);
                            softUniC[indexFirstC]= token[2];
                            softUniC[indexSecondC] = token[1];
                            if (softUniC.Contains($"{token[1]}-Exercise"))
                            {
                                softUniC.Remove($"{token[1]}-Exercise");
                                softUniC.Insert(indexSecondC+1, $"{token[1]}-Exercise");
                            }
                            if (softUniC.Contains($"{token[2]}-Exercise"))
                            {
                                softUniC.Remove($"{token[2]}-Exercise");
                                softUniC.Insert(indexFirstC + 1, $"{token[2]}-Exercise");
                            }
                        }
                        break;
                    case "Exercise":
                        if (softUniC.Contains(token[1]) && !softUniC.Contains($"{token[1]}-Exercise"))
                        {
                            int indexCourse = softUniC.IndexOf(token[1]);
                            softUniC.Insert(indexCourse+1, $"{token[1]}-Exercise");
                        }
                        else if (!softUniC.Contains(token[1]))
                        {
                            softUniC.Add(token[1]);
                            softUniC.Add($"{token[1]}-Exercise");

                        }
                        break;
                    default:
                        Console.WriteLine(string.Join(" ", softUniC));
                        break;
                }

                command = Console.ReadLine();
            }
            for (int i = 0; i < softUniC.Count; i++)
            {
                Console.WriteLine($"{i+1}.{softUniC[i]}");
            }
        }
    }
}
