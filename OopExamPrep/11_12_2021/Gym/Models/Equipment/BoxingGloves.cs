using System;
using System.Collections.Generic;
using System.Text;

namespace Gym.Models.Equipment
{
    public class BoxingGloves : Equipment
    {
        private const double BoxingGlovesWeights = 227;
        private const decimal BoxingGlovesPrice = 120m;
        public BoxingGloves()
            : base(BoxingGlovesWeights, BoxingGlovesPrice)
        {
        }
    }
}

