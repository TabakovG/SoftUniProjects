﻿using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Race : IRace
    {
        private string raceName;
        private int numberOfLaps;
        private bool tookPlace;
        private readonly List<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
            this.pilots = new List<IPilot>();
            this.tookPlace = false;
        }

        public string RaceName
        { 
            get => this.raceName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidRaceName, value));
                }
                this.raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get => this.numberOfLaps;
            private set 
            {
                if (value < 1)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidLapNumbers, value));
                }
                this.numberOfLaps = value;
            }
        }

        public bool TookPlace 
        {
            get => this.tookPlace;
            set
            { 
                this.tookPlace = value;
            }
        }

        public ICollection<IPilot> Pilots => this.pilots;

        public void AddPilot(IPilot pilot)
        {
            this.pilots.Add(pilot);
        }

        public string RaceInfo()
        {
            var tp = this.TookPlace ? "Yes" : "No";

            var sb = new StringBuilder();
            sb.AppendLine($"The {this.RaceName} race has:");
            sb.AppendLine($"Participants: {this.Pilots.Count}");
            sb.AppendLine($"Number of laps: {this.NumberOfLaps}");
            sb.AppendLine($"Took place: {tp}");

            return sb.ToString().Trim();
        }
    }
}
