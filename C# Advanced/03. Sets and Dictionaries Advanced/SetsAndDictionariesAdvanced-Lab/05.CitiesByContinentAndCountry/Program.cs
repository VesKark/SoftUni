using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        var continentData = new Dictionary<string, Dictionary<string, List<string>>>();
        int inputData = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputData; i++)
        {
            string[] cityData = Console.ReadLine().Split();
            string continent = cityData[0];
            string country = cityData[1];
            string city = cityData[2];

            if (!continentData.ContainsKey(continent))
            {
                continentData[continent] = new Dictionary<string, List<string>>();
            }
            
            if (!continentData[continent].ContainsKey(country))
            {
                continentData[continent][country] = new List<string>();
            }
                          
            continentData[continent][country].Add(city);                     
        }

        foreach (var continent in continentData)
        {
            Console.WriteLine($"{continent.Key}:");

            foreach (var country in continent.Value)
            {
                Console.WriteLine($"\t{country.Key} -> {string.Join(", ", country.Value)}");
            }
        }
    }
}