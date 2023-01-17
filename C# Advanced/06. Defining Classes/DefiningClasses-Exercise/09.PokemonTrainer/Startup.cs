using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // input trainers and their caught pokemons:
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] inputData = input.Split(' ');
                string trainerName = inputData[0];
                string pokemonName = inputData[1];
                string pokemonElement = inputData[2];
                int pokemonHealth = int.Parse(inputData[3]);

                Pokemon caughtPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(0, new List<Pokemon>() { caughtPokemon });
                    trainers[trainerName] = trainer;
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(caughtPokemon);
                }
            }

            // receive commands:
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Value.Pokemons.Any(x => x.Element == input))
                    {
                        trainer.Value.Badges += 1;
                    }
                    else
                    {
                        trainer.Value.Pokemons.Select(x => x.Health -= 10).ToList();

                        for (int i = 0; i < trainer.Value.Pokemons.Count; i++)
                        {
                            if (trainer.Value.Pokemons[i].Health <= 0)
                            {
                                trainer.Value.Pokemons.RemoveAt(i);
                            }
                        }
                    }
                }
            }

            //  print remaining trainers:
            foreach (var trainer in trainers.OrderByDescending(x => x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count()}");
            }
        }
    }
}
