﻿using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            foreach (var astronaut in astronauts)
            {
                while (astronaut.Oxygen > 0)
                {
                    astronaut.Bag.Items.Add(planet.Items.First()); // to be checked 
                    planet.Items.Remove(planet.Items.First());
                    astronaut.Breath();
                }
            }
        }
    }
}
