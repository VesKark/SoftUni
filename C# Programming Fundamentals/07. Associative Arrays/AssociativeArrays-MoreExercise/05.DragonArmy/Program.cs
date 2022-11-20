internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfDragons = int.Parse(Console.ReadLine());
        Dictionary<string, List<Dragon>> allDragons = new Dictionary<string, List<Dragon>>();
        for (int i = 0; i < numberOfDragons; i++)
        {
            string[] inputDragon = Console.ReadLine().Split();
            string dragonType = inputDragon[0];
            string dragonName = inputDragon[1];
            int damage = int.TryParse(inputDragon[2], out damage) ? damage : 45;
            int health = int.TryParse(inputDragon[3], out health) ? health : 250;
            int armor = int.TryParse(inputDragon[4], out armor) ? armor : 10;

            Dragon currDragon = new Dragon(dragonName, damage, health, armor);

            if (!allDragons.ContainsKey(dragonType))
            {
                allDragons.Add(dragonType, new List<Dragon> { currDragon });
            }
            else if (!allDragons[dragonType].Any(x => x.Name == dragonName))
            {
                allDragons[dragonType].Add(currDragon);
            }
            else
            {
                foreach (Dragon dragon in allDragons[dragonType].Where(x => x.Name == dragonName))
                {
                    dragon.Damage = damage;
                    dragon.Health = health;
                    dragon.Armor = armor;
                }
            }
        }

        // print dragons:
        foreach (var dragonType in allDragons)
        {
            double averageDamage = dragonType.Value.Select(x => x.Damage).Average();
            double averageHealth = dragonType.Value.Select(x => x.Health).Average();
            double averageArmor = dragonType.Value.Select(x => x.Armor).Average();

            Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", dragonType.Key, averageDamage, averageHealth, averageArmor);

            foreach (Dragon currDragon in dragonType.Value.OrderBy(x => x.Name))
            {
                Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", currDragon.Name, currDragon.Damage, currDragon.Health, currDragon.Armor);
            }
        }
    }
}

class Dragon
{
    public Dragon(string name, int damage, int health, int armor)
    {
        Name = name;
        Damage = damage;
        Health = health;
        Armor = armor;
    }

    public string Name { get; set; }
    public int Damage { get; set; }
    public int Health { get; set; }
    public int Armor { get; set; }
}