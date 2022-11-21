using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string number = Console.ReadLine();
        int multiplier = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        int restOfProduct = 0;

        if (multiplier == 0 || number == "0")
        {
            Console.WriteLine(0);
            return;
        }

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digit = (number[i] - 48);

            int digitProduct = digit * multiplier + restOfProduct;
            int append = digitProduct % 10;
            restOfProduct = digitProduct / 10;

            sb.Insert(0, append);            
        }

        if (restOfProduct != 0)
        {
            sb.Insert(0, restOfProduct);
        }

        Console.WriteLine(sb);
    }
}