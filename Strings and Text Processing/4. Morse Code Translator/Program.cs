using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> morseCode = new Dictionary<string, string>
            {
                ["A"] = ".-",
                ["B"] = "-...",
                ["C"] = "-.-.",
                ["D"] = "-..",
                ["E"] = ".",
                ["F"] = "..-.",
                ["G"] = "--.",
                ["H"] = "....",
                ["I"] = "..",
                ["J"] = ".---",
                ["K"] = "-.-",
                ["L"] = ".-..",
                ["M"] = "--",
                ["N"] = "-.",
                ["O"] = "---",
                ["P"] = ".--.",
                ["Q"] = "--.-",
                ["R"] = ".-.",
                ["S"] = "...",
                ["T"] = "-",
                ["U"] = "..-",
                ["V"] = "...-",
                ["W"] = ".--",
                ["X"] = "-..-",
                ["Y"] = "-.--",
                ["Z"] = "--.."
            };

            string[] code = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);
            string msg = string.Empty;

            foreach (var item in code)
            {
                string[] letters = item.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var ltr in letters)
                {
                    var kvp = morseCode.FirstOrDefault(x => x.Value == ltr.Trim());
                    msg += kvp.Key;

                }

                msg += ' ';
            }
            Console.WriteLine(msg);
        }
    }
}
