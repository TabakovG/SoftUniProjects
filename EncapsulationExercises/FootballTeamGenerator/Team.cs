using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private readonly List<Player> players;
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ErrMsg.InvalidName);
                }
                name = value;
            }
        }

        public int Rating
        {
            get
            {
                if (this.players.Count > 0)
                {
                    return (int)Math.Round(players.Average(x => x.stats.OveralStats), 0);
                }
                return 0;
            }
        }


        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            var player = this.players.FirstOrDefault(p => p.Name == playerName);
            if (player == null)
            {
                throw new ArgumentException(string.Format(ErrMsg.MissingPlayer, playerName, this.Name));
            }
            this.players.Remove(player);
        }
    }
}
