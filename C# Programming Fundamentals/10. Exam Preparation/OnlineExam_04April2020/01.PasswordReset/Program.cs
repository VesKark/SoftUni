using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        string password = Console.ReadLine();
        string command = string.Empty;
        StringBuilder sb = new StringBuilder();

        while ((command = Console.ReadLine()) != "Done")
        {
            string[] fullCommand = command.Split();
            string action = fullCommand[0];

            if (action == "TakeOdd")
            {
                for (int i = 1; i < password.Length; i += 2)
                {
                    sb.Append(password[i]);
                }
                password = sb.ToString();
            }
            else if (action == "Cut")
            {
                int index = int.Parse(fullCommand[1]);
                int length = int.Parse(fullCommand[2]);
                password = password.Remove(index, length);
            }
            else if (action == "Substitute")
            {
                string substring = fullCommand[1];
                string substitute = fullCommand[2];

                if (password.Contains(substring))
                {
                    password = password.Replace(substring, substitute);
                }
                else
                {
                    Console.WriteLine("Nothing to replace!");
                    continue;
                }
            }

            Console.WriteLine(password);
        }

        Console.WriteLine("Your password is: {0}", password);
    }
}