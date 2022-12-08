using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = string.Empty;

        // input all cities:
        Dictionary<string, City> cities = new Dictionary<string, City>();

        while ((input = Console.ReadLine()) != "Sail")
        {
            string[] city = input.Split("||");
            string cityName = city[0];
            int population = int.Parse(city[1]);
            int gold = int.Parse(city[2]);

            City currCity = new City(population, gold);

            if (!cities.ContainsKey(cityName))
            {
                cities[cityName] = currCity;
            }
            else
            {
                cities[cityName].Population += population;
                cities[cityName].Gold += gold;
            }
        }

        // sail through the cities:
        while ((input = Console.ReadLine()) != "End")
        {
            string[] cityEvents = input.Split("=>");
            string activity = cityEvents[0];
            string cityName = cityEvents[1];

            if (activity == "Plunder")
            {
                int people = int.Parse(cityEvents[2]);
                int gold = int.Parse(cityEvents[3]);

                Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");

                cities[cityName].Gold -= gold;
                cities[cityName].Population -= people;

                if (cities[cityName].Gold <= 0 || cities[cityName].Population <= 0)
                {
                    cities.Remove(cityName);
                    Console.WriteLine($"{cityName} has been wiped off the map!");
                }
            }
            else if (activity == "Prosper")
            {
                int gold = int.Parse(cityEvents[2]);

                if (gold < 0)
                {
                    Console.WriteLine("Gold added cannot be a negative number!");
                }
                else
                {
                    cities[cityName].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {cities[cityName].Gold} gold.");
                }
            }
        }

        // print remaining cities:
        if (!cities.Any())
        {
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            return;
        }

        Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

        foreach (var city in cities)
        {
            Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
        }
    }
}

class City
{
    public City(int population, int gold)
    {
        Population = population;
        Gold = gold;
    }

    public int Population { get; set; }
    public int Gold { get; set; }
}