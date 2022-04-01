using System;
using System.Linq;

namespace Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encriptedMsg = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] cmd = command.Split(":|:");

                string action = cmd[0];

                switch (action)
                {
                    case "InsertSpace":
                        int index = int.Parse(cmd[1]);

                        encriptedMsg = encriptedMsg.Insert(index, " ");
                        
                        break;
                    case "Reverse":
                        string substr = cmd[1];

                        if (encriptedMsg.Contains(substr))
                        {
                            int indexSubStr = encriptedMsg.IndexOf(substr);
                            encriptedMsg = encriptedMsg.Remove(indexSubStr, substr.Length);
                            encriptedMsg += string.Join("", substr.Reverse().ToArray());
                        }
                        else
                        {
                            Console.WriteLine("error");
                            command = Console.ReadLine();
                            continue;
                        }

                        break;
                    case "ChangeAll":

                        string strToReplace = cmd[1];
                        string newText = cmd[2];

                        encriptedMsg =  encriptedMsg.Replace(strToReplace, newText);

                        break;
                }
                Console.WriteLine(encriptedMsg);
                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {encriptedMsg}");
        }
    }
}
