using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int lostGames = int.Parse(Console.ReadLine()); //count of lost games
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            // Estimating expenses for trashed components:
            double expenses = 
                headsetPrice * (lostGames / 2) + 
                mousePrice * (lostGames / 3) + 
                keyboardPrice * (lostGames / 6) + 
                displayPrice * (lostGames / 12);

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
