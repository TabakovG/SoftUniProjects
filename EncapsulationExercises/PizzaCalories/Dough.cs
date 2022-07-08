using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const double White = 1.5;
        private const double Wholegrain = 1.0;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1.0;

        private const double BaseCalories = 2;

        private double weight;
        private string florType;
        private double flourModifier;
        private double techniqueModifier;
        private string technique;

        private string FlorType
        {
            get { return florType; }
            set
            {
                if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
                {
                    this.florType = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else
                {
                    throw new ArgumentException(ErrorMsg.InvalidDough);
                }
            }
        }

        private double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException(ErrorMsg.InvalidWeight);
                }
                this.weight = value;
            }
        }

        private string Technique
        {
            get
            {
                return this.technique;
            }
            set
            {
                value = value.ToLower();
                if (value == "crispy" || value == "chewy" || value == "homemade")
                {
                    this.technique = value[0].ToString().ToUpper() + value.Substring(1);
                }
                else
                {
                    throw new ArgumentException(ErrorMsg.InvalidDough);
                }

            }
        }

        internal double Calories => BaseCalories * this.flourModifier * this.techniqueModifier * this.Weight;

        public Dough(string florType, string technique, double weight)
        {
            this.FlorType = florType;
            this.Technique = technique;
            this.Weight = weight;

            this.flourModifier = this.florType == "White" ? White : Wholegrain;
            this.techniqueModifier = this.technique == "Crispy" ? Crispy :
                                        this.technique == "Chewy" ? Chewy : Homemade;
        }

    }
}
