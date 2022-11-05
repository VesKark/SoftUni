using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string pattern = @">>([A-Za-z]+)<<(\d+(?:\.\d+)?)\!(\d+)";
        List<string> boughtFurniture = new List<string>();

        string input = string.Empty;
        double totalPrice = 0;

        while ((input = Console.ReadLine()) != "Purchase")
        {
            Match purchase = Regex.Match(input, pattern);

            if (purchase.Success)
            {
                string furniture = purchase.Groups[1].Value;
                double price = double.Parse(purchase.Groups[2].Value);
                int quantity = int.Parse(purchase.Groups[3].Value);

                totalPrice += price * quantity;
                if (!boughtFurniture.Contains(furniture))
                {
                    boughtFurniture.Add(furniture);
                }
            }
        }

        Console.WriteLine("Bought furniture:");
        foreach (string furniture in boughtFurniture)
        {
            Console.WriteLine(furniture);
        }
        Console.WriteLine($"Total money spend: {totalPrice:F2}");
    }
}