using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Pokemon_Trainer
{
    public class Trainer
    {
        private List<Pokemon> pokemons;

        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons {get; set; }


        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }
    }
}
