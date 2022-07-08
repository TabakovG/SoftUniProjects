using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;

        public Stats stats { get; }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ErrMsg.InvalidName);
                }
                name = value;
            }
        }

        public Player(string name, Stats stats)
        {
            this.Name = name;
            this.stats = stats;
        }
    }
}
