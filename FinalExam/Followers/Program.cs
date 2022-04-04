using System;
using System.Collections.Generic;

namespace Followers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, Followers> followers = new Dictionary<string, Followers>();
            while (command != "Log out")
            {
                string[] cmd = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string action = cmd[0];
                string username = cmd[1];

                switch (action)
                {
                    case "New follower":
                        if (!followers.ContainsKey(username))
                        {
                            followers[username] = new Followers(username, 0, 0);
                        }
                        break;
                    case "Like":
                        int likes = int.Parse(cmd[2]);
                        if (!followers.ContainsKey(username))
                        {
                            followers[username] = new Followers(username, likes, 0);
                        }
                        else
                        {
                            followers[username].Likes += likes;
                        }
                        break;
                    case "Comment":
                        if (!followers.ContainsKey(username))
                        {
                            followers[username] = new Followers(username, 0, 1);
                        }
                        else
                        {
                            followers[username].Comments ++;
                        }
                        break;
                    case "Blocked":
                        if (followers.ContainsKey(username))
                        {
                            followers.Remove(username);
                        }
                        else 
                        {
                            Console.WriteLine($"{username} doesn't exist.");
                        }
                        break;
                }


                command = Console.ReadLine();
            }
            Console.WriteLine($"{followers.Count} followers");
            foreach (var item in followers)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Likes+item.Value.Comments}");
            }
        }
    }
    class Followers
    {
        public string Username { get; set; }
        public int Likes { get; set; }
        public int Comments { get; set; }

        public Followers(string name, int likes, int comments)
        {
            this.Username = name;
            this.Likes = likes;
            this.Comments = comments;
        }
    }
}
