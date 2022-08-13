using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Battleship : Vessel, IBattleship
    {
        private const int BsDefaultArmor = 300;
        private bool sonarMode = false;

        public Battleship(string name, double mainWeaponCaliber, double speed) 
            : base(name, mainWeaponCaliber, speed, BsDefaultArmor)
        {
        }

        public override int DefaultArmour => BsDefaultArmor;

        public bool SonarMode
        { 
            get => this.sonarMode;
            private set => this.sonarMode = value;
        }

        public void ToggleSonarMode()
        {
            this.SonarMode = !this.SonarMode;

            if (this.SonarMode)
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 5;
            }
            else
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 5;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            string sonar = this.SonarMode ? "ON" : "OFF";
            sb.AppendLine(base.ToString())
                .AppendLine($" *Sonar mode: {sonar}");
            return sb.ToString().Trim();
        }

    }
}
