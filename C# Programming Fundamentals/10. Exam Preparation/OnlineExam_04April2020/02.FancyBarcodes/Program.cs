using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        int barcodesCount = int.Parse(Console.ReadLine());
        string pattern = @"\@#{1,}(?<code>[A-Z][A-Za-z0-9]{4,}[A-Z])\@#{1,}";

        for (int i = 0; i < barcodesCount; i++)
        {
            string input = Console.ReadLine();
            Match currCode = Regex.Match(input, pattern);

            if (currCode.Success)
            {
                string codeValue = currCode.Groups["code"].Value;

                if (!codeValue.Any(char.IsDigit))
                {
                    Console.WriteLine("Product group: 00");
                }
                else
                {
                    string digits = new string(codeValue.Where(Char.IsDigit).ToArray());
                    Console.WriteLine("Product group: {0}", digits);
                }
            }
            else
            {
                Console.WriteLine("Invalid barcode");
            }
        }
    }
}