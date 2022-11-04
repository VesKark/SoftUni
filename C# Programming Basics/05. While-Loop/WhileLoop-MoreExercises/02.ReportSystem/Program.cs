using System;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int collectedSum = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int donations = 0;
            int countDonations = 0;
            int countCashPayments = 0;
            int countCardPayments = 0;
            int donationsCash = 0;
            int donationsCard = 0;

            // Collecting donations:
            while (input != "End")
            {
                donations = int.Parse(input);
                countDonations++;

                if (countDonations % 2 != 0 && donations <= 100)
                {
                    collectedSum -= donations;
                    donationsCash += donations;
                    countCashPayments++;
                    Console.WriteLine("Product sold!");
                }
                else if (countDonations % 2 != 0 && donations > 100)
                {
                    Console.WriteLine("Error in transaction!");
                }


                if (countDonations % 2 == 0 && donations >= 10)
                {
                    collectedSum -= donations;
                    donationsCard += donations;
                    countCardPayments++;
                    Console.WriteLine("Product sold!");
                }
                else if (countDonations % 2 == 0 && donations < 10)
                {
                    Console.WriteLine("Error in transaction!");
                }

                if (collectedSum <= 0)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            // Output:
            if (collectedSum <= 0)
            {
                Console.WriteLine($"Average CS: {donationsCash * 1.00 / countCardPayments:F2}");
                Console.WriteLine($"Average CC: {donationsCard * 1.00 / countCardPayments:F2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
