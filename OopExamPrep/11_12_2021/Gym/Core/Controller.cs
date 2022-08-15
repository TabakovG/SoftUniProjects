using Gym.Core.Contracts;
using Gym.Models.Athletes;
using Gym.Models.Athletes.Contracts;
using Gym.Models.Equipment;
using Gym.Models.Gyms;
using Gym.Models.Gyms.Contracts;
using Gym.Repositories;
using Gym.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gym.Core
{
    public class Controller : IController
    {
        private readonly EquipmentRepository equipment;
        private readonly List<IGym> gyms;

        public Controller()
        {
            this.equipment = new EquipmentRepository();
            this.gyms = new List<IGym>();
        }

        public string AddGym(string gymType, string gymName)
        {
            switch (gymType)
            {
                case "BoxingGym":
                    this.gyms.Add(new BoxingGym(gymName));
                    break;
                case "WeightliftingGym":
                    this.gyms.Add(new WeightliftingGym(gymName));
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidGymType);
            }

            return String.Format(OutputMessages.SuccessfullyAdded, gymType);
        }

        public string AddEquipment(string equipmentType)
        {
            switch (equipmentType)
            {
                case "BoxingGloves":
                    this.equipment.Add(new BoxingGloves());
                    break;
                case "Kettlebell":
                    this.equipment.Add(new Kettlebell());
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidEquipmentType);
            }
            return String.Format(OutputMessages.SuccessfullyAdded, equipmentType);
        }

        public string InsertEquipment(string gymName, string equipmentType)
        {
            var eqp = this.equipment.FindByType(equipmentType);
            var gym = this.gyms.FirstOrDefault(g=>g.Name == gymName);

            if (eqp == null)
            {
                throw new InvalidOperationException(
                    string.Format(ExceptionMessages.InexistentEquipment, equipmentType));
            }

            gym.AddEquipment(eqp);
            this.equipment.Remove(eqp);

            return String.Format(OutputMessages.EntityAddedToGym, equipmentType, gymName);

        }

        public string AddAthlete(string gymName, string athleteType, string athleteName, string motivation, int numberOfMedals)
        {
            var gym = this.gyms.FirstOrDefault(g => g.Name == gymName);
            IAthlete athlete = null;
            var canUse = false;
            if (athleteType == "Boxer")
            {
                athlete = new Boxer(athleteName, motivation, numberOfMedals);
                if (gym.GetType().Name == "BoxingGym")
                {
                    canUse = true;
                }
            }
            else if (athleteType == "Weightlifter")
            { 
                athlete = new Weightlifter(athleteName, motivation, numberOfMedals);
                if (gym.GetType().Name == "WeightliftingGym")
                {
                    canUse = true;
                }
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAthleteType);
            }

            if (!canUse)
            {
                return OutputMessages.InappropriateGym;
            }

            gym.AddAthlete(athlete);

            return String.Format(OutputMessages.EntityAddedToGym, athleteType, gymName);
        }

        public string TrainAthletes(string gymName)
        {
            var gym = this.gyms.FirstOrDefault(g => g.Name == gymName);

            foreach (var athlet in gym.Athletes)
            {
                athlet.Exercise();
            }
            return String.Format(OutputMessages.AthleteExercise, gym.Athletes.Count);

        }

        public string EquipmentWeight(string gymName)
        {
            var gym = this.gyms.FirstOrDefault(g => g.Name == gymName);

            return String.Format(OutputMessages.EquipmentTotalWeight, gymName, gym.EquipmentWeight);
        }

        public string Report()
        {
            var sb = new StringBuilder();

            foreach (var gym in this.gyms)
            {
                sb.AppendLine(gym.GymInfo());
            }
            return sb.ToString().Trim();
        }
    }
}
