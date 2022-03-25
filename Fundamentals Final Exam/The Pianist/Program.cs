using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, string>> pieces = new Dictionary<string, Dictionary<string, string>>();

            for (int i = 0; i < num; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split("|");

                string name = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                pieces.Add(name, new Dictionary<string, string>() {[composer] = key });
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] cmd = command.Split("|");

                string action = cmd[0];
                string piece = cmd[1];

                switch (action)
                {
                    case "Add":
                        if (pieces.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            string composer = cmd[2];
                            string key = cmd[3];
                            pieces.Add(piece, new Dictionary<string, string>() { [composer] = key});
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                    case "Remove":

                        if (!pieces.ContainsKey(piece))
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        else
                        {
                            pieces.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        break;
                    case "ChangeKey":
                        if (!pieces.ContainsKey(piece))
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        else
                        {
                            string newKey = cmd[2];
                            var item = pieces[piece].FirstOrDefault();
                            pieces[piece] = new Dictionary<string, string>{ [item.Key] = newKey};
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        break;
                    default:
                        break;
                }


                command = Console.ReadLine();
            }
            if (pieces.Count > 0)
            {
            foreach (var item in pieces)
            {
                foreach (var subItem in item.Value)
                {
                Console.WriteLine($"{item.Key} -> Composer: {subItem.Key}, Key: {subItem.Value}");
                }
            }
            }
        }
    }
}
