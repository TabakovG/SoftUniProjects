using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        private const int Initial_Oxygen = 70;
        public Biologist(string name)
            : base(name, Initial_Oxygen)
        {
        }

        public override void Breath()
        {
            this.Oxygen -= 5;
            if (this.Oxygen < 0)
            {
                this.Oxygen = 0;
            }
        }
    }
}
