using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int pokePowerN = int.Parse(Console.ReadLine());
            int pokeDistanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            // Counting pokes:
            int countPokes = 0;
            int startingPokePower = pokePowerN;

            while (pokePowerN >= pokeDistanceM)
            {
                pokePowerN -= pokeDistanceM;
                countPokes++;

                if (pokePowerN == 0.50 * startingPokePower && exhaustionFactorY != 0)
                {
                    pokePowerN /= exhaustionFactorY;                    
                }
            }

            // Output game results:
            Console.WriteLine(pokePowerN);
            Console.WriteLine(countPokes);
        }
    }
}
