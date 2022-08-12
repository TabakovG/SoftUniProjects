using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Fish;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }
        public string AddAquarium(string aquariumType, string aquariumName)
        {
            Aquarium aq = null;
            switch (aquariumType)
            {
                case "FreshwaterAquarium":
                    aq = new FreshwaterAquarium(aquariumName);
                    break;
                case "SaltwaterAquarium":
                    aq = new SaltwaterAquarium(aquariumName);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            this.aquariums.Add(aq);

            return String.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            Decoration dec = null;
            switch (decorationType)
            {
                case "Ornament":
                    dec = new Ornament();
                    break;
                case "Plant":
                    dec = new Plant();
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }
            this.decorations.Add(dec);
            return String.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            var decor = this.decorations.Models.FirstOrDefault(d=>d.GetType().Name == decorationType);
            if (decor == null)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }
            var aqua = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);
            aqua.AddDecoration(decor);
            decorations.Remove(decor);
            return String.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }
        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            Fish fish = null;
            var aqua = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            switch (fishType)
            {
                case "FreshwaterFish":
                    fish = new FreshwaterFish(fishName,fishSpecies,price);
                    break;
                case "SaltwaterFish":
                    fish = new SaltwaterFish(fishName, fishSpecies, price);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            //!! What about saltfish in freshwater ???
            if (aqua.GetType().Name.Replace("Aquarium", "") != fishType.Replace("Fish", ""))
            {
                return OutputMessages.UnsuitableWater;
            }
            aqua.AddFish(fish);

            return String.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
        }

        public string FeedFish(string aquariumName)
        {
            var aqua = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            foreach (var fish in aqua.Fish)
            {
                fish.Eat();
            }
            return String.Format(OutputMessages.FishFed, aqua.Fish.Count);
        }
        public string CalculateValue(string aquariumName)
        {
            var aqua = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            decimal totalPrice = aqua.Fish.Sum(f => f.Price) + aqua.Decorations.Sum(d=>d.Price);

            return String.Format(OutputMessages.AquariumValue, aquariumName, $"{totalPrice:f2}");
        }

        public string Report()
        {
            var sb = new StringBuilder();
            foreach (var aq in this.aquariums)
            {
                sb.AppendLine(aq.GetInfo());
            }
            return sb.ToString().Trim();
        }
    }
}
