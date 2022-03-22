using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string,int>> players = new Dictionary<string, Dictionary<string,int>>();

            string command = Console.ReadLine();
            while (command != "Season end")
            {
                string[] cmdTrim = command.Split(" ");

                if (cmdTrim[1] == "vs")
                {
                    string[] cmd = command.Split(" vs ");

                    Fight(players, cmd);
                }
                else
                {
                    string[] cmd = command.Split(" -> ");

                    AddPlayer(players, cmd);

                }

                command = Console.ReadLine();
            }

            foreach (var item in players.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");

                foreach (var pos in item.Value.OrderByDescending(s => s.Value).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"- {pos.Key} <::> {pos.Value}");
                }
            }
        }

        public static void AddPlayer(Dictionary<string, Dictionary<string, int>> players, string[] cmd)
        {
            string playerName = cmd[0];
            string position = cmd[1];
            int skillPoints = int.Parse(cmd[2]);

            if (!players.ContainsKey(playerName))
            {
                players[playerName] = new Dictionary<string, int>();
            }
            if (!players[playerName].ContainsKey(position))
            {
                players[playerName][position] = 0;
            }
            if (players[playerName][position] < skillPoints)
            {
                players[playerName][position] = skillPoints;
            }
        }

        public static void Fight(Dictionary<string, Dictionary<string, int>> players, string[] cmd)
        {
            string playerOne = cmd[0];
            string playerTwo = cmd[1];

            if (players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
            {
                foreach (var position in players[playerOne])
                {
                    if (players[playerTwo].ContainsKey(position.Key))
                    {
                        int pOneTotalPoints = players[playerOne].Values.Sum();
                        int pTwoTotalPoints = players[playerTwo].Values.Sum();

                        if (pOneTotalPoints > pTwoTotalPoints)
                        {
                            players.Remove(playerTwo);
                        }
                        else if (pOneTotalPoints < pTwoTotalPoints)
                        {
                            players.Remove(playerOne);
                        }
                        break;
                    }
                }
            }

        }
    }
}
