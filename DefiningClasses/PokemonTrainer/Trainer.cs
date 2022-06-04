using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numBadges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int NumBadges
        {
            get { return numBadges; }
            set { numBadges = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return pokemons; }
            set { pokemons = value; }
        }

        public Trainer(string name)
        {
            this.Name = name;
            this.NumBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }
    }
}
