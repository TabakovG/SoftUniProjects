namespace FishingNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Net
    {
        public List<Fish> Fish { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }

        public Net(string material, int capacity)
        {
            this.Material = material;
            this.Capacity = capacity;
            this.Fish = new List<Fish>();
        }

        public int Count { get=>this.Fish.Count;}

        public string AddFish(Fish fish)
        {
            if (string.IsNullOrEmpty(fish.FishType) || fish.Length <= 0 || fish.Weight <= 0)
            {
                return "Invalid fish.";
            }
            else if (this.Capacity == this.Count)
            {
                return "Fishing net is full.";
            }
            else
            {
                this.Fish.Add(fish);
                return $"Successfully added {fish.FishType} to the fishing net.";
            }
        }

        public bool ReleaseFish(double weight)
        {
            return this.Fish.Remove(this.Fish.FirstOrDefault(f=>f.Weight == weight));
        }
        public Fish GetFish(string fishType)
        {
            return this.Fish.FirstOrDefault(f => f.FishType == fishType);
        }
        public Fish GetBiggestFish()
        {
            return this.Fish.OrderByDescending(f => f.Length).FirstOrDefault();
        }
        public string Report()
        {
            return $"Into the {this.Material}:" + Environment.NewLine + 
                $"{string.Join(Environment.NewLine, this.Fish.OrderByDescending(f => f.Length))}";
        }

    }
}
