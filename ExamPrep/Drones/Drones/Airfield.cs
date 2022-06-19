namespace Drones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Airfield
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public List<Drone> Drones { get; set; }
        public int Count { get => this.Drones.Count; }

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }

        public string AddDrone(Drone drone)
        {
            if (Count < Capacity)
            {
                if (!string.IsNullOrEmpty(drone.Name)  && !string.IsNullOrEmpty(drone.Brand)
                    && drone.Range >= 5 && drone.Range <= 15)
                {
                    Drones.Add(drone);
                    return $"Successfully added {drone.Name} to the airfield.";
                }
                else
                {
                    return "Invalid drone.";
                }
            }
            else
            {
                return "Airfield is full.";
            }
        }

        public bool RemoveDrone(string name)
        {
            if (Drones.Find(d => d.Name == name) != null)
            {
                var droneToRemove = Drones.Find(d => d.Name == name);
                Drones.Remove(droneToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = Drones.FindAll(d => d.Brand == brand).Count;

            Drones.RemoveAll(d => d.Brand == brand);
            return count;
        }

        public Drone FlyDrone(string name)
        {
            if (Drones.Find(d => d.Name == name) != null)
            {
                var drone = Drones.Find(d => d.Name == name);
                drone.Available = false;
                return drone;
            }
            else
            {
                return null;
            }
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            
            List<Drone> flyDrones = new List<Drone>(Drones.Where(d => d.Range >= range));
            flyDrones = flyDrones.Select(drone => FlyDrone(drone.Name)).ToList();
            return flyDrones;
        }

        public string Report()
        {
            var availableDrones = Drones.Where(d => d.Available == true).ToList();
            if (availableDrones.Count > 0)
            {
            return $"Drones available at {this.Name}:" + Environment.NewLine 
                + $"{string.Join(Environment.NewLine, availableDrones)}";
            }
            return $"Drones available at {this.Name}:";
        }
    }
}
