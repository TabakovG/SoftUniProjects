using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {

        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
            Weight = 0;
            Color = "n/a";
        }

        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine, weight)
        {
            Color = color;
        }
    }
}
