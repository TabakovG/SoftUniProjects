using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main()
        {
            string cmd = Console.ReadLine();
            List<Team> teams = new List<Team>();
            while (cmd != "END")
            {
                try
                {
                    string[] input = cmd.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    string action = input[0];
                    string teamName = input[1];
                    if (action != "Team" && teams.FirstOrDefault(x => x.Name == teamName) == null)
                    {
                        throw new ArgumentException(string.Format(ErrMsg.InvalidTeam, teamName));
                    }
                    switch (action)
                    {
                        case "Team":
                            teams.Add(new Team(teamName));
                            break;
                        case "Add":
                            int[] data = input.Skip(3).Select(int.Parse).ToArray();
                            var stats = new Stats(data[0], data[1], data[2], data[3], data[4]);
                            var player = new Player(input[2], stats);
                            teams.First(t => t.Name == teamName).AddPlayer(player);
                            break;
                        case "Remove":
                            {
                                var team = teams.FirstOrDefault(x => x.Name == teamName);
                                string playerName = input[2];
                                team.RemovePlayer(playerName);
                                break;
                            }
                        case "Rating":
                            {
                                var team = teams.FirstOrDefault(x => x.Name == teamName);
                                Console.WriteLine($"{team.Name} - {team.Rating}");
                                break;
                            }
                    }
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(ErrMsg.InvalidName);
                }
                

                cmd = Console.ReadLine();
            }
        }
    }
}
