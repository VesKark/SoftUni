using System.Net.Sockets;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] separator = new string[]{ ",", " " };
        string[] allTickets = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);

        string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";
        Regex regex = new Regex(pattern);

        for (int i = 0; i < allTickets.Length; i++)
        {
            if (allTickets[i].Length == 20)
            {
                Match firstHalf = regex.Match(allTickets[i].Substring(0, 10));
                Match secondHalf = regex.Match(allTickets[i].Substring(10));
                int minLength = Math.Min(firstHalf.Length, secondHalf.Length);

                if (firstHalf.Success && secondHalf.Success)
                {
                    string winFirstHalf = firstHalf.Value.Substring(0, minLength);
                    string winSecondHalf = secondHalf.Value.Substring(0, minLength);

                    if (winFirstHalf.Equals(winSecondHalf))
                    {
                        if (winFirstHalf.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{allTickets[i]}\" - {minLength}{winFirstHalf.Substring(0, 1)} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{allTickets[i]}\" - {minLength}{winFirstHalf.Substring(0, 1)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{allTickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{allTickets[i]}\" - no match");
                }
            }
            else
            {
                Console.WriteLine("invalid ticket");
            }
        }
    }
}