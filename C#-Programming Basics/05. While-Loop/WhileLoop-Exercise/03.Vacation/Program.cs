using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            double tripCosts = double.Parse(Console.ReadLine());
            double savings = double.Parse(Console.ReadLine());

            string spendOrSave = "";
            double money = 0;
            int countSpend = 0;
            int countDays = 0;

            // Saving and Spending:
            while (savings < tripCosts)
            {
                spendOrSave = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                countDays++;

                switch (spendOrSave)
                {
                    case "spend": 
                        savings -= money;
                        if (savings < 0)
                        {
                            savings = 0;
                        }
                        countSpend++;
                        break;
                    case "save":
                        savings += money;
                        countSpend = 0;
                        break;
                }

                if (countSpend == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(countDays);
                    break;
                }
            }

            //Output:
            if (savings >= tripCosts)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
        }
    }
}
