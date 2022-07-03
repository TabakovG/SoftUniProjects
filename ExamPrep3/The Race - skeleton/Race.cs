using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        public List<Racer> data { get; private set; }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get=>this.data.Count; }

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.data = new List<Racer>();
        }

        public void Add(Racer Racer)
        {
            if (this.Count < Capacity)
            {
                this.data.Add(Racer);
            }
        }
        public bool Remove(string name)
        { 
            var racerToRemove = this.data.FirstOrDefault(x => x.Name == name);
            return data.Remove(racerToRemove);
        }
        public Racer GetOldestRacer()
        { 
            return this.data.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name)
        { 
            return this.data.FirstOrDefault(x => x.Name == name);
        }
        public Racer GetFastestRacer()
        { 
            return this.data.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
        }
        public string Report()
        {
            return $"Racers participating at {this.Name}:" + Environment.NewLine +
                $"{string.Join(Environment.NewLine, this.data)}";
        }
    }
}
