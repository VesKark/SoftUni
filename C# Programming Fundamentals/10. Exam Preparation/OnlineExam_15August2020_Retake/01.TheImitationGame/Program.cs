using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        string message = Console.ReadLine();
        string instruction = string.Empty;

        while ((instruction = Console.ReadLine()) != "Decode")
        {
            string[] currInstruction = instruction.Split('|');
            string command = currInstruction[0];

            if (command == "Move")
            {
                int index = int.Parse(currInstruction[1]);
                string movePart = message.Substring(0, index);
                message = message.Remove(0, index);
                message = message.Insert(message.Length, movePart);
            }
            else if (command == "Insert")
            {
                int index = int.Parse(currInstruction[1]);
                string insertValue = currInstruction[2];

                message = message.Insert(index, insertValue);
            }
            else if (command == "ChangeAll")
            {
                string substring = currInstruction[1];
                string replacement = currInstruction[2];

                while (message.Contains(substring))
                {
                    message = message.Replace(substring, replacement);
                }
            }
        }

        Console.WriteLine("The decrypted message is: {0}", message);
    }
}