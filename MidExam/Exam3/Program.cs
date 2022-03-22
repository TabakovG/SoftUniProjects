using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<string> chat = new List<string>();

            while (command != "end")
            {
                string[] token = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (token[0])
                {
                    case "Chat":
                        chat.Add(token[1]);
                        break;
                    case "Delete":
                        if (chat.Contains(token[1]))
                        {
                            chat.Remove(token[1]);
                        }
                        break;
                    case "Edit":
                        if (chat.Contains(token[1]))
                        {
                            int index = chat.IndexOf(token[1]);
                            chat[index] = token[2];
                        }
                        break;
                    case "Pin":
                        if (chat.Contains(token[1]))
                        {
                            chat.Remove(token[1]);
                            chat.Add(token[1]);
                        }
                        break;
                    case "Spam":

                        for (int j = 1; j < token.Length; j++)
                        {
                            chat.Add(token[j]);
                        }

                        break;
                }

                command = Console.ReadLine();
            }
            for (int i = 0; i < chat.Count; i++)
            {
                Console.WriteLine(chat[i]);
            }
        }
    }
}
