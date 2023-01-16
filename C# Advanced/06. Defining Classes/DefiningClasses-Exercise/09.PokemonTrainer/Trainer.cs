using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(int badges, List<Pokemon> pokemons)
        {
            Badges = badges;
            Pokemons = pokemons;
        }
    }
}
