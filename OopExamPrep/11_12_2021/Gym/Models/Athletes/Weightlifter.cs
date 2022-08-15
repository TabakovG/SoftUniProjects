using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Athletes
{
    public class Weightlifter : Athlete
    {
        private const int WeightlifterInitialStamina = 50;
        private const int WeightlifterStaminaBoost = 10;
        public Weightlifter(string fullName, string motivation, int numberOfMedals)
            : base(fullName, motivation, numberOfMedals, WeightlifterInitialStamina)
        {
        }

        public override void Exercise()
        {
            this.Stamina += WeightlifterStaminaBoost;
            base.Exercise();
        }
    }
}
