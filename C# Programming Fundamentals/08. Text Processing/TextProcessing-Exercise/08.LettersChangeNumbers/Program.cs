internal class Program
{
    private static void Main(string[] args)
    {
        string[] cards = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        double cardsSum = 0;

        foreach (string card in cards)
        {
            char firstLetter = card.First();
            char lastLetter = card.Last();
            int number = int.Parse(card.Substring(1, card.Length - 2));

            int firstPosition = char.ToLower(firstLetter) - 96;
            int lastPosition = char.ToLower(lastLetter) - 96;

            double mathEquations = 0;

            if (Char.IsUpper(firstLetter))
            {
                mathEquations = number * 1.00 / firstPosition;
            }
            else
            {
                mathEquations = number * 1.00 * firstPosition;
            }

            if (Char.IsUpper(lastLetter))
            {
                mathEquations -= lastPosition;
            }
            else
            {
                mathEquations += lastPosition;
            }

            cardsSum += mathEquations;
        }

        Console.WriteLine($"{cardsSum:F2}");
    }
}