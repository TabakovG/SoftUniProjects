using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment
{
    public class Kettlebell : Equipment
    {
        private const double KettlebellWeights = 10000;
        private const decimal KettlebellPrice = 80m;
        public Kettlebell()
            : base(KettlebellWeights, KettlebellPrice)
        {
        }
    }
}
