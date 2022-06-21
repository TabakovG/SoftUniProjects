namespace Zoo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Zoo
    {
        public List<Animal> Animals { get; private set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public Zoo(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Animals = new List<Animal>();
        }

        public string AddAnimal(Animal animal)
        {
            if (string.IsNullOrEmpty(animal.Species))
            {
                return "Invalid animal species.";
            }
            if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            if (Animals.Count == this.Capacity)
            {
                return "The zoo is full.";
            }
            this.Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            return this.Animals.RemoveAll(a => a.Species == species);
        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            var animalByDiet = this.Animals.Where(a => a.Diet == diet).ToList();
            return animalByDiet;
        }
        public Animal GetAnimalByWeight(double weight)
        { 
            return this.Animals.FirstOrDefault(a => a.Weight == weight);
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            var animalsByLength = this.Animals.FindAll(a => a.Length >= minimumLength && a.Length <= maximumLength);
            return $"There are {animalsByLength.Count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
