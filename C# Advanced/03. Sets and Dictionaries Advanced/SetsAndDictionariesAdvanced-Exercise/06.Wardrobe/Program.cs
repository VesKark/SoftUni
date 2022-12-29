using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();
        int inputCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputCount; i++)
        {
            // add color to wardrobe:
            string[] inputClothes = Console.ReadLine().Split(" -> ");
            string color = inputClothes[0];

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe[color] = new Dictionary<string, int>();
            }

            // add clothes to wardrobe:
            string[] clothes = inputClothes[1].Split(",");

            for (int j = 0; j < clothes.Length; j++)
            {
                if (!wardrobe[color].ContainsKey(clothes[j]))
                {
                    wardrobe[color].Add(clothes[j], 1);
                }
                else
                {
                    wardrobe[color][clothes[j]]++;
                }
            }
        }

        // input searched item in wardrobe:
        string[] findItem = Console.ReadLine().Split();
        string findColor = findItem[0];
        string findClothes = findItem[1];        

        // print wardrobe:
        foreach (var color in wardrobe)
        {
            Console.WriteLine($"{color.Key} clothes:");

            bool printFoundItem = false;
            if (findColor == color.Key)
            {
                printFoundItem = true;
            }

            foreach (var cloth in color.Value)
            {
                if (printFoundItem && cloth.Key == findClothes)
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                }
            }
        }
    }
}