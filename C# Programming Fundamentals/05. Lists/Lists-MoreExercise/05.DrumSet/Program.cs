using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // input:
            double savings = double.Parse(Console.ReadLine());
            List<int> drumQty = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            // copy list
            List<int> startDrumQty = new List<int>();
            foreach (int item in drumQty)
            {
                startDrumQty.Add(item);
            }

            // drum practice:
            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < drumQty.Count; i++)
                {                    
                    drumQty[i] -= hitPower;
                    if (drumQty[i] <= 0)
                    {
                        drumQty[i] = startDrumQty[i];
                        int drumCosts = startDrumQty[i] * 3;

                        if (savings >= drumCosts)
                        {
                            savings -= drumCosts;
                        }
                        else
                        {
                            drumQty.RemoveAt(i);
                            startDrumQty.RemoveAt(i);
                            i--;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", drumQty));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
