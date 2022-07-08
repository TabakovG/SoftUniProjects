using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Stats
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public double OveralStats { get => (this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0; }

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }


        private int Endurance
        {
            get => this.endurance;
            set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException(string.Format(ErrMsg.InvalidStat, nameof(this.Endurance)));
                }
                endurance = value;
            }
        }
        private int Sprint
        {
            get => this.sprint;
            set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException(string.Format(ErrMsg.InvalidStat, nameof(this.Sprint)));
                }
                this.sprint = value;
            }
        }
        private int Dribble
        {
            get => this.dribble;
            set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException(string.Format(ErrMsg.InvalidStat, nameof(this.Dribble)));
                }
                this.dribble = value;
            }
        }
        private int Passing
        {
            get => this.passing;
            set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException(string.Format(ErrMsg.InvalidStat, nameof(this.Passing)));
                }
                this.passing = value;
            }
        }
        private int Shooting
        {
            get => this.shooting;
            set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException(string.Format(ErrMsg.InvalidStat, nameof(this.Shooting)));
                }
                this.shooting = value;
            }
        }
    }
}
