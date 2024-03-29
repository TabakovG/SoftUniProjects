﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    internal static class ErrMsg
    {
        public const string InvalidName = "A name should not be empty.";
        public const string InvalidStat = "{0} should be between 0 and 100.";
        public const string MissingPlayer = "Player {0} is not in {1} team.";
        public const string InvalidTeam = "Team {0} does not exist.";
    }
}
