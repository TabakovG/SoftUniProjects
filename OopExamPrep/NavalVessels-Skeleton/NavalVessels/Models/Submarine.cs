using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, ISubmarine
    {
        private const int SbmDefaultArmor = 200;
        private bool submergeMode = false;

        public Submarine(string name, double mainWeaponCaliber, double speed) 
            : base(name, mainWeaponCaliber, speed, SbmDefaultArmor)
        {
        }

        public override int DefaultArmour => SbmDefaultArmor;
        public bool SubmergeMode
        { 
            get { return this.submergeMode; }
            private set { this.submergeMode = value; }
        }


        public void ToggleSubmergeMode()
        {
            this.SubmergeMode = !this.SubmergeMode;

            if (this.SubmergeMode)
            {
                this.MainWeaponCaliber += 40;
                this.Speed -= 4;
            }
            else
            {
                this.MainWeaponCaliber -= 40;
                this.Speed += 4;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            string submerge = this.SubmergeMode ? "ON" : "OFF";
            sb.AppendLine(base.ToString())
                .AppendLine($" *Submerge mode: {submerge}");
            return sb.ToString().Trim();
        }
    }
}
