using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays_MoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contest = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> submission = new SortedDictionary<string, Dictionary<string, int>>();

            string firstInput = Console.ReadLine();

            while (firstInput != "end of contests")
            {
                string[] token = firstInput.Split(":", StringSplitOptions.RemoveEmptyEntries);
                contest.Add(token[0], token[1]);

                firstInput = Console.ReadLine();
            }

            string secInput = Console.ReadLine();

            while (secInput != "end of submissions")
            {
                string[] cmd = secInput.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                ProcessInput(contest, submission, cmd[2], cmd[1], cmd[0], int.Parse(cmd[3]));

                secInput = Console.ReadLine();
            }

            string topUser = "";
            int topUserPoints = 0;
            foreach (var item in submission)
            {
                int totalPoints = item.Value.Values.Sum();
                if (totalPoints>topUserPoints)
                {
                    topUserPoints = totalPoints;
                    topUser = item.Key;
                }
            }

            Console.WriteLine($"Best candidate is {topUser} with total {topUserPoints} points.");
            Console.WriteLine("Ranking:");


            foreach (var user in submission)
            {
                Console.WriteLine($"{user.Key}");
                foreach (var course in user.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {course.Key} -> {course.Value}");
                }
            }
        }

        static void ProcessInput(Dictionary<string, string> contest, SortedDictionary<string, Dictionary<string, int>> submission,
            string username, string password, string course, int points)
        {
            if (contest.ContainsKey(course))
            {
                if (contest[course] == password)
                {
                    if (!submission.ContainsKey(username))
                    {
                        submission[username] = new Dictionary<string, int>();
                    }
                    if (!submission[username].ContainsKey(course))
                    {
                        submission[username][course] = 0;
                    }
                    if (submission[username][course] < points)
                    {
                        submission[username][course] = points;
                    }
                    
                }
            }
        }
    }
}
