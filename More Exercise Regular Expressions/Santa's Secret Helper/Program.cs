using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            List<string> goodKids = new List<string>();
            string encriptedMsg = Console.ReadLine();

            while (encriptedMsg != "end")
            {
                string decriptedMsg = string.Empty;

                foreach (char ch in encriptedMsg)
                {
                    decriptedMsg += (char)(ch - num);
                }

                string pattern = @"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*\!(?<behaivior>[GN])\!";
                Match validInput = Regex.Match(decriptedMsg, pattern);

                if (validInput.Success && validInput.Groups["behaivior"].Value == "G")
                {
                    goodKids.Add(validInput.Groups["name"].Value);
                }

                encriptedMsg = Console.ReadLine();

            }
            Console.WriteLine(string.Join(Environment.NewLine, goodKids));

        }
    }
}
