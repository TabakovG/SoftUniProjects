using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public class Boxer : Athlete
    {
        private const int BoxerInitialStamina = 60;
        private const int BoxerStaminaBoost = 15;

        public Boxer(string fullName, string motivation, int numberOfMedals)
            : base(fullName, motivation, numberOfMedals, BoxerInitialStamina)
        {
        }

        public override void Exercise()
        {
            this.Stamina += BoxerStaminaBoost;
            base.Exercise();
        }
    }
}
