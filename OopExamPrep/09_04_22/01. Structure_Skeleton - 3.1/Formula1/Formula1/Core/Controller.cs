using Formula1.Core.Contracts;
using Formula1.Models;
using Formula1.Models.Cars;
using Formula1.Repositories;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formula1.Core
{
    public class Controller : IController
    {
        private PilotRepository pilotRepository;
        private RaceRepository raceRepository;
        private FormulaOneCarRepository carRepository;

        public Controller()
        {
            this.pilotRepository = new PilotRepository();
            this.raceRepository = new RaceRepository();
            this.carRepository = new FormulaOneCarRepository();
        }
        public string CreatePilot(string fullName)
        {
            if (this.pilotRepository.Models.Any(x => x.FullName == fullName))
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.PilotExistErrorMessage, fullName));
            }

            this.pilotRepository.Add(new Pilot(fullName));
            return String.Format(OutputMessages.SuccessfullyCreatePilot, fullName);

        }
        public string CreateCar(string type, string model, int horsepower, double engineDisplacement)
        {
            if (this.carRepository.Models.Any(c=>c.Model == model))
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.CarExistErrorMessage, model));
            }

            FormulaOneCar car = null;
            switch (type)
            {
                case "Ferrari": 
                    car = new Ferrari(model, horsepower, engineDisplacement); 
                    break; 
                case "Williams": 
                    car = new Williams(model, horsepower, engineDisplacement); 
                    break; 
                default:
                    throw new InvalidOperationException(
                        String.Format(ExceptionMessages.InvalidTypeCar, type));
            }

            this.carRepository.Add(car);
            return string.Format(OutputMessages.SuccessfullyCreateCar, type, model);


        }

        public string CreateRace(string raceName, int numberOfLaps)
        {
            if (this.raceRepository.Models.Any(c => c.RaceName == raceName))
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.RaceExistErrorMessage, raceName));
            }
            this.raceRepository.Add(new Race(raceName, numberOfLaps));
            return string.Format(OutputMessages.SuccessfullyCreateRace, raceName);
        }
        public string AddCarToPilot(string pilotName, string carModel)
        {
            var pilot = pilotRepository.FindByName(pilotName);
            var car = carRepository.FindByName(carModel);

            if (pilot == null || pilot.Car != null)
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.PilotDoesNotExistOrHasCarErrorMessage,pilotName));
            }
            if (car == null)
            {
                throw new NullReferenceException(
                    String.Format(ExceptionMessages.CarDoesNotExistErrorMessage, carModel));
            }

            pilot.AddCar(car);
            carRepository.Remove(car);
            return string.Format(
                OutputMessages.SuccessfullyPilotToCar, pilotName, car.GetType().Name, carModel);

        }

        public string AddPilotToRace(string raceName, string pilotFullName)
        {
            var race = raceRepository.FindByName(raceName);
            var pilot = pilotRepository.FindByName(pilotFullName);

            if (race == null)
            {
                throw new NullReferenceException(
                    String.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }
            if (pilot == null || pilot.CanRace == false || race.Pilots.Any(p=>p.FullName == pilotFullName))
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.PilotDoesNotExistErrorMessage, pilotFullName));
            }
            race.AddPilot(pilot);
            return String.Format(OutputMessages.SuccessfullyAddPilotToRace, pilotFullName, raceName);
        }
        public string StartRace(string raceName)
        {
            var race = raceRepository.FindByName(raceName);
            if (race == null)
            {
                throw new NullReferenceException(
                    String.Format(ExceptionMessages.RaceDoesNotExistErrorMessage, raceName));
            }
            if (race.Pilots.Count() < 3)
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.InvalidRaceParticipants,raceName));
            }
            if (race.TookPlace)
            {
                throw new InvalidOperationException(
                    String.Format(ExceptionMessages.RaceTookPlaceErrorMessage, raceName));
            }

            var fastestRiders = 
                race.Pilots
                .OrderByDescending(p => p.Car.RaceScoreCalculator(race.NumberOfLaps))
                .Take(3)
                .ToArray();
            race.TookPlace = true;
            var winner = fastestRiders[0];
            var secondPlace = fastestRiders[1];
            var thirdPlace = fastestRiders[2];
            winner.WinRace();

            var sb = new StringBuilder();
            sb.AppendLine(String.Format(OutputMessages.PilotFirstPlace, winner.FullName, raceName));
            sb.AppendLine(String.Format(OutputMessages.PilotSecondPlace, secondPlace.FullName, raceName));
            sb.AppendLine(String.Format(OutputMessages.PilotThirdPlace, thirdPlace.FullName, raceName));

            return sb.ToString().Trim();

        }
        public string RaceReport()
        {
            var sb = new StringBuilder();
            foreach (var race in raceRepository.Models.Where(r=>r.TookPlace))
            {
                sb.AppendLine(race.RaceInfo());
            }
            return sb.ToString().Trim();
        }
        public string PilotReport()
        {
            var sb = new StringBuilder();

            foreach (var pilot in pilotRepository.Models.OrderByDescending(p=>p.NumberOfWins))
            {
                sb.AppendLine(pilot.ToString());
            }
            return sb.ToString().Trim();
        }


    }
}
