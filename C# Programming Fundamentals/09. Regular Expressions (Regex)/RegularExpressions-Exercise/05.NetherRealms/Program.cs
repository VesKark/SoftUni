using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] separator = new string[] { " ", "," };
        string[] inputDemonNames = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

        SortedDictionary<string, Demon> allDemons = new SortedDictionary<string, Demon>();

        for (int i = 0; i < inputDemonNames.Length; i++)
        {
            string demonName = inputDemonNames[i];

            // estimate demon health:
            string healthPattern = @"[^0-9\+\-\*\/\.]";

            char[] matches = Regex.Matches(demonName, healthPattern)
                .Cast<Match>()
                .Select(m => m.Value)
                .Select(char.Parse)
                .ToArray();

            int health = 0;
            foreach (char currChar in matches)
            {
                health += currChar;
            }

            // estimate demon damage:
            string damagePattern = @"(\-(?:\d+(?:\.\d+)?))|((?:\d+(?:\.\d+)?))";

            double[] numbers = Regex.Matches(demonName, damagePattern)
                .Cast<Match>()
                .Select(m => m.Value)
                .Select(double.Parse)
                .ToArray();

            double damage = 0;
            foreach (double currNum in numbers)
            {
                damage += currNum;
            }

            // multiply or divide demon damage:
            string multipyDividePattern = @"[\*\/]";

            char[] multipyDivideMatches = Regex.Matches(demonName, multipyDividePattern)
                .Cast<Match>()
                .Select(m => m.Value)
                .Select(char.Parse)
                .ToArray();

            foreach (char currChar in multipyDivideMatches)
            {
                if (currChar == '*')
                {
                    damage *= 2;
                }
                else if (currChar == '/')
                {
                    damage /= 2;
                }
            }

            allDemons[demonName] = new Demon(health, damage);
        }

        foreach (var demon in allDemons)
        {
            Console.WriteLine("{0} - {1} health, {2:f2} damage", demon.Key, demon.Value.Health, demon.Value.Damage);
        }
    }
}

class Demon
{
    public Demon(int health, double damage)
    {
        Health = health;
        Damage = damage;
    }
    public int Health { get; set; }
    public double Damage { get; set; }
}