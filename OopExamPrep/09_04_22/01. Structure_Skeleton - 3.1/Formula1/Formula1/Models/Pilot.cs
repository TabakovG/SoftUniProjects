using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private bool canRace;
        private IFormulaOneCar car;
        private int numberOfWins;

        public Pilot(string fullName)
        {
            this.FullName = fullName;
            this.NumberOfWins = 0;
            this.canRace = false;
        }

        public string FullName
        {
            get => this.fullName;
            private set 
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPilot, value));
                }
                this.fullName = value; 
            }
        }

        public IFormulaOneCar Car
        { 
            get =>  this.car;
            private set 
            {
                if (value == null)
                {
                    throw new NullReferenceException(ExceptionMessages.InvalidCarForPilot);
                }
                this.car = value;
            }
        }


        public int NumberOfWins
        {
            get => this.numberOfWins;
            private set
            { 
                this.numberOfWins = value;
            }
        }

        public bool CanRace
        {
            get => this.canRace;
            private set
            { 
                this.canRace = value;
            }
        }

        public void AddCar(IFormulaOneCar car)
        {
            this.Car = car;
            this.CanRace = true;
        }

        public void WinRace()
        {
            this.NumberOfWins++;
        }
        public override string ToString()
        {
            return $"Pilot {this.FullName} has {this.NumberOfWins} wins.";
        }
    }
}
