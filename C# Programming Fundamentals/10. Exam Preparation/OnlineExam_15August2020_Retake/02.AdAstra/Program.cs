using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(\||\#)(?<food>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,5})\1";
        List<Food> foodList = new List<Food>();

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            string food = match.Groups["food"].Value;
            string date = match.Groups["date"].Value;
            int calories = int.Parse(match.Groups["calories"].Value);

            Food inputFood = new Food(food, date, calories);
            foodList.Add(inputFood);
        }

        int totalCalories = foodList.Select(x => x.Calories).Sum();
        int dayCalories = 2000;

        Console.WriteLine("You have food to last you for: {0} days!", totalCalories / dayCalories);

        foreach (Food foodInList in foodList)
        {
            Console.WriteLine("Item: {0}, Best before: {1}, Nutrition: {2}", foodInList.FoodName, foodInList.ExpirationDate, foodInList.Calories);
        }
    }
}

class Food
{
    public Food(string food, string date, int calories)
    {
        FoodName = food;
        ExpirationDate = date;
        Calories = calories;
    }

    public string FoodName { get; set; }
    public string ExpirationDate { get; set; }
    public int Calories { get; set; }
}