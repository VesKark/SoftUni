using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { 
        int pumpsCount = int.Parse(Console.ReadLine());
        Queue<Pump> pumps = new Queue<Pump>();

        // input pumps data:
        for (int i = 0; i < pumpsCount; i++)
        {
            string pumpData = Console.ReadLine();
            int amount = int.Parse(pumpData.Split()[0]);
            int distance = int.Parse(pumpData.Split()[1]);

            Pump currPump = new Pump(i, amount, distance);
            pumps.Enqueue(currPump);
        }

        // find start point of truck tour:        
        int startPoint = 0;

        for (int i = 0; i < pumpsCount; i++)
        {
            startPoint = i;
            int totalAmount = 0;
            Queue<Pump> pumpTour = new Queue<Pump>(pumps);
            bool tourSuccess = true;

            for (int j = 0; j < pumpsCount; j++)
            {
                Pump thisPump = pumpTour.Dequeue();

                totalAmount += thisPump.Amount;

                if (thisPump.Distance <= totalAmount)
                {
                    totalAmount -= thisPump.Distance;
                }
                else
                {
                    tourSuccess = false;
                    break;
                }
            }

            if (tourSuccess)
            {
                break;
            }

            Pump currPump = pumps.Dequeue();
            pumps.Enqueue(currPump);
        }

        Console.WriteLine(startPoint);
    }
}

class Pump
{
    public Pump (int name, int amount, int distance)
    {
        Name = name;
        Amount = amount;
        Distance = distance;
    }
    public int Name { get; set; }
    public int Amount { get; set; }
    public int Distance { get; set; }
}