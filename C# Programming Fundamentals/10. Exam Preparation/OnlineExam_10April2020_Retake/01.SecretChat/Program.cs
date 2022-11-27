using System;

public class Program
{
    public static void Main()
    {
        string concealedMessage = Console.ReadLine();
        string instructions = string.Empty;
        string[] separator = new string[] { ":|:" };

        while ((instructions = Console.ReadLine()) != "Reveal")
        {
            string[] operation = instructions.Split(separator, StringSplitOptions.None);
            string command = operation[0];

            if (command == "InsertSpace")
            {
                int index = int.Parse(operation[1]);
                concealedMessage = concealedMessage.Insert(index, " ");
                Console.WriteLine(concealedMessage);
            }
            else if (command == "Reverse")
            {
                string substring = operation[1];

                if (concealedMessage.Contains(substring))
                {
                    int index = concealedMessage.IndexOf(substring);
                    concealedMessage = concealedMessage.Remove(index, substring.Length);

                    // reverse substring:
                    char[] charArray = substring.ToCharArray();
                    Array.Reverse(charArray);
                    substring = new string(charArray);

                    concealedMessage = concealedMessage.Insert(concealedMessage.Length, substring);
                    Console.WriteLine(concealedMessage);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (command == "ChangeAll")
            {
                string substring = operation[1];
                string replacement = operation[2];
                concealedMessage = concealedMessage.Replace(substring, replacement);
                Console.WriteLine(concealedMessage);
            }
        }

        Console.WriteLine("You have a new text message: {0}", concealedMessage);
    }
}