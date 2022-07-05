using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        private string _userName;
        public int _level;


        public string Username
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
