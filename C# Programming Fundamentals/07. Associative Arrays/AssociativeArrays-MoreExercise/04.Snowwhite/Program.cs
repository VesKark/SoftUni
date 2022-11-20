using System.Globalization;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, int> allDwarfs = new Dictionary<string, int>();
        // key -> dwarf HatColor + Name ; value -> dwarf Physics

        string input = string.Empty;

        while ((input = Console.ReadLine()) != "Once upon a time")
        {
            string[] inputDwarf = input.Split(" <:> ");
            string name = inputDwarf[0];
            string hatColor = inputDwarf[1];
            int physics = int.Parse(inputDwarf[2]);

            string dwarfID = "(" + hatColor + ") " + name;

            if (!allDwarfs.ContainsKey(dwarfID))
            {
                allDwarfs.Add(dwarfID, physics);
            }
            else if (allDwarfs[dwarfID] < physics)
            {
                allDwarfs[dwarfID] = physics;
            }
        }

        foreach (var dwarf in allDwarfs.OrderByDescending(x => x.Value).ThenByDescending(x => allDwarfs.Where(y => y.Key.Split()[0] == x.Key.Split()[0]).Count()))
        {
            Console.WriteLine("{0} <-> {1}", dwarf.Key, dwarf.Value);
        }
    }
}