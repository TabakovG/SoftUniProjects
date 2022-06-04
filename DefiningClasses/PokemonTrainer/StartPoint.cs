using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartPoint
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            Prepare(trainers);

            Fight(trainers);

            PrintResults(trainers);
            

        }


        private static void Prepare(List<Trainer> trainers)
        {
            string command = Console.ReadLine();
            while (command != "Tournament")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!trainers.Select(t => t.Name).Contains(cmd[0]))
                {
                    var newTrainer = new Trainer(cmd[0]);
                    trainers.Add(newTrainer);
                }
                var trainer = trainers.FirstOrDefault(t => t.Name == cmd[0]);
                var newPokemon = new Pokemon(cmd[1], cmd[2], int.Parse(cmd[3]));
                trainer.Pokemons.Add(newPokemon);

                command = Console.ReadLine();
            }
        }
        private static void Fight(List<Trainer> trainers)
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(n => n.Element == input))
                    {
                        trainer.NumBadges++;
                    }
                    else
                    {
                        foreach (var pkmn in trainer.Pokemons)
                        {
                            pkmn.Health -= 10;
                        }
                        trainer.Pokemons = trainer.Pokemons.Where(n => n.Health > 0).ToList();
                    }
                }

                input = Console.ReadLine();
            }
        }
        private static void PrintResults(List<Trainer> trainers)
        {
            foreach (var trainer in trainers.OrderByDescending(t=>t.NumBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
