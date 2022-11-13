using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        int countCommands = int.Parse(Console.ReadLine());
        List<int> houseNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int visitHouseNumber = 0;

        for (int i = 0; i < countCommands; i++)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];             

            if (action == "Forward")
            {
                int step = int.Parse(command[1]);                
                visitHouseNumber += step;

                if (visitHouseNumber < 0 || visitHouseNumber >= houseNumbers.Count)
                {
                    visitHouseNumber -= step;
                    continue;
                }
                houseNumbers.RemoveAt(visitHouseNumber);
            }
            else if (action == "Back")
            {
                int step = int.Parse(command[1]);
                visitHouseNumber -= step;

                if (visitHouseNumber < 0 || visitHouseNumber >= houseNumbers.Count)
                {
                    visitHouseNumber += step;
                    continue;
                }
                houseNumbers.RemoveAt(visitHouseNumber);
            }
            else if (action == "Gift")
            {
                int index = int.Parse(command[1]);
                int houseNumber = int.Parse(command[2]);

                if (index < 0 || index >= houseNumbers.Count)
                {
                    continue;
                }

                houseNumbers.Insert(index, houseNumber);
                visitHouseNumber = index;
            }
            else if (action == "Swap")
            {
                int first = int.Parse(command[1]);
                int second = int.Parse(command[2]);
                int indexOfFirst = houseNumbers.IndexOf(first);
                int indexOfSecond = houseNumbers.IndexOf(second);

                if (indexOfFirst < 0 || indexOfFirst >= houseNumbers.Count)
                {
                    continue;
                }
                if (indexOfSecond < 0 || indexOfSecond >= houseNumbers.Count)
                {
                    continue;
                }

                int temp = houseNumbers[indexOfFirst];
                houseNumbers[indexOfFirst] = houseNumbers[indexOfSecond];
                houseNumbers[indexOfSecond] = temp;
            }
        }

        Console.WriteLine("Position: {0}", visitHouseNumber);
        Console.WriteLine(String.Join(", ", houseNumbers));
    }    
}