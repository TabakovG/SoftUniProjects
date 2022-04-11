using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songs = new Queue<string>(input);

            while (true)
            {
                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "Play":
                        if (songs.Count != 0)
                        {
                            songs.Dequeue();
                        }
                        break;
                    case "Show":
                        if (songs.Count != 0)
                        {
                            Console.WriteLine(String.Join(", ", songs));
                        }
                        break;
                    default: //Add:
                        string songName = cmd.Substring(3, cmd.Length-3).Trim();
                        if (!songs.Contains(songName))
                        {
                            songs.Enqueue(songName);
                        }
                        else
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        break;
                }

                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    return;
                }
            }
        }
    }
}
