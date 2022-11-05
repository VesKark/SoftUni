using System.Text;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        int messagesCount = int.Parse(Console.ReadLine());
        string pattern = @"\@([A-Za-z]+)[^\@\-\!\:\>]*?\:(\d+)[^\@\-\!\:\>]*?\!(A|D)\![^\@\-\!\:\>]*?\-\>(\d+)";

        List<string> attackedPlantest = new List<string>();
        List<string> destoryedPlantest = new List<string>();

        for (int i = 0; i < messagesCount; i++)
        {
            string code = Console.ReadLine();
            string decryptedMessage = RemoveCountFromCode(code);

            Match matchMessage = Regex.Match(decryptedMessage, pattern);

            if (matchMessage.Success)
            {
                string planetName = matchMessage.Groups[1].Value;
                char attackType = char.Parse(matchMessage.Groups[3].Value);

                if (attackType == 'A')
                {
                    attackedPlantest.Add(planetName);
                }
                else if (attackType == 'D')
                {
                    destoryedPlantest.Add(planetName);
                }
            }
        }

        Console.WriteLine("Attacked planets: {0}", attackedPlantest.Count);
        PrintPlanets(attackedPlantest);

        Console.WriteLine("Destroyed planets: {0}", destoryedPlantest.Count);
        PrintPlanets(destoryedPlantest);
    }

    public static void PrintPlanets(List<string> plantes)
    {
        foreach (string planet in plantes.OrderBy(n => n))
        {
            Console.WriteLine("-> {0}", planet);
        }
    }

    public static string RemoveCountFromCode(string code)
    {
        StringBuilder sb = new StringBuilder();
        int count = CountSTARLetters(code);

        foreach (char currChar in code)
        {
            sb.Append((char)(currChar - count));
        }
        return sb.ToString();
    }

    public static int CountSTARLetters(string code)
    {
        string key = @"[starSTAR]";
        MatchCollection matches = Regex.Matches(code, key);
        return matches.Count;
    }
}