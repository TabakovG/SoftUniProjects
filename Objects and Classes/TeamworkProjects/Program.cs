using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

                if (IsValidTeamName(teams, input[1]))
                {
                    if (IsValidCreator(teams, input[0]))
                    {
                        teams.Add(new Team(input[0], input[1]));
                        Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                }


            }

            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string[] newMember = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                if (IsMemberValid(teams, newMember[1], newMember[0]))
                {
                    Team teamToModify = teams.FirstOrDefault(x => x.TeamName == newMember[1]);

                    teamToModify.Members.Add(newMember[0]);
                }
                command = Console.ReadLine();
            }

            List<Team> teamsToDisband = new List<Team>();
            teamsToDisband = teams.FindAll(team => team.Members.Count == 0);

            teamsToDisband = teamsToDisband.OrderBy(team => team.TeamName).ToList();

            List<Team> validTeams = new List<Team>();
            validTeams = teams.FindAll(team => team.Members.Count != 0);
            validTeams = validTeams.OrderByDescending(team => team.Members.Count)
                .ThenBy(t => t.TeamName).ToList();

            foreach (var item in validTeams)
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.Creator}");
                Console.WriteLine($"-- {string.Join(Environment.NewLine + "-- ", item.Members.OrderBy(x => x))}");
            }
            Console.WriteLine("Teams to disband:");
            foreach (var disTeam in teamsToDisband)
            {
                Console.WriteLine($"{disTeam.TeamName}");
            }


        }
        static bool IsValidCreator(List<Team> teams, string cName)
        {
            foreach (var team in teams)
            {
                if (team.Creator == cName)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsValidTeamName(List<Team> teams, string tName)
        {
            foreach (var team in teams)
            {
                if (team.TeamName == tName)
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsMemberValid(List<Team> teams, string teamName, string memeberName) 
        {
            if (teams.Any(team => team.TeamName == teamName))
            {
                if (teams.Any(team => team.Members.Contains(memeberName)) 
                    || teams.Any(team => team.Creator == memeberName))
                {
                    Console.WriteLine($"Member {memeberName} cannot join team {teamName}!");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                return false;
            }
        }
    }

    class Team
    {
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Members { get; set; }

        public Team(string creator, string tName)
        {
            this.Creator = creator;
            this.TeamName = tName;

            this.Members = new List<string>();
        }
    }
}
