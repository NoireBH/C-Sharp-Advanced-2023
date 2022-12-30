using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var trainersWithTheirPokemon = new Dictionary<string, Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] parts = input.Split();
                string trainerName = parts[0];
                string pokemonName = parts[1];
                string pokemonElement = parts[2];
                int pokemonHealth = int.Parse(parts[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(trainerName);

                if (!trainersWithTheirPokemon.ContainsKey(trainerName))
                {
                    trainersWithTheirPokemon.Add(trainerName, trainer);

                }

                trainersWithTheirPokemon[trainerName].AddPokemon(pokemon);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainersWithTheirPokemon)
                {
                    if (trainer.Value.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        trainer.Value.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Value.Pokemons.RemoveAll(p => p.Health <= 0);                        
                    }
                }
            }

            foreach (var trainer in trainersWithTheirPokemon.OrderByDescending(t => t.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
