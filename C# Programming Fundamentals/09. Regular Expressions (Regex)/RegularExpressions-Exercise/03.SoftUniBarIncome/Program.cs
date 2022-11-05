using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = string.Empty;
        string pattern = @"%(?<customer>[A-Z][a-z]+)%[^\|\$\%\.]*?<(?<product>\w+)>[^\|\$\%\.]*?\|(?<count>\d+)\|[^\|\$\%\.]*?(?<price>\d+(?:\.\d+)?)\$";

        double totalIncome = 0;

        while ((input = Console.ReadLine()) != "end of shift")
        {
            Match purchase = Regex.Match(input, pattern);

            if (purchase.Success)
            {
                string customer = purchase.Groups["customer"].Value;
                string product = purchase.Groups["product"].Value;
                int count = int.Parse(purchase.Groups["count"].Value);
                double price = double.Parse(purchase.Groups["price"].Value);
                double totalPrice = count * price;
                totalIncome += totalPrice;

                Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");
            }
        }

        Console.WriteLine($"Total income: {totalIncome:F2}");
    }
}