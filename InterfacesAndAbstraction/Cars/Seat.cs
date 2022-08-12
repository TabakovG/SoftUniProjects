using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public string Model { get; private set; }
        public string Color { get; private set; }

        public string Start()
        {
            return "Engine start";
        }

        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} Seat {this.Model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());
            return sb.ToString().Trim();
        }
    }
}
