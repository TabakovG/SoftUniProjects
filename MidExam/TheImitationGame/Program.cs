using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> inputList = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                inputList.Add(input[i].ToString());
            }

            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] token = command.Split("|", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (token[0])
                {
                    case "Move":
                        for (int i = 0; i < int.Parse(token[1]) % inputList.Count; i++)
                        {
                            inputList.Add(inputList[0]);
                            inputList.RemoveAt(0);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(token[1]);
                        if (index >= 0 && index <= inputList.Count)
                        {
                            foreach (char item in token[2].Reverse())
                            {
                                inputList.Insert(index, item.ToString());

                            }
                        }
                        break;
                    case "ChangeAll":
                        StringBuilder currentResult = new StringBuilder();
                        currentResult.Append(string.Join("", inputList));
                        currentResult.Replace(token[1], token[2]);
                        List<char> newList = currentResult.ToString().ToList();
                        List<string> newListconvertToStr = new List<string>();
                        for (int j = 0; j < newList.Count; j++)
                        {
                            newListconvertToStr.Add(newList[j].ToString());
                        }
                        inputList = newListconvertToStr;

                        break;
                    default:
                        Console.WriteLine($"The decrypted message is: {string.Join("", inputList)}");
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {string.Join("", inputList)}");
        }
    }
}
