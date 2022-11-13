﻿using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        StringBuilder decryptedMessage = new StringBuilder();
        string pattern = @"\@(?<name>[A-Za-z]+)[^\@\-\!\:\>]*?\!(?<behaviour>G|N)\!";

        string message = Console.ReadLine();

        while (message != "end")
        {
            foreach (char currChar in message)
            {
                decryptedMessage.Append((char)(currChar - key));
            }

            Match matchMessage = Regex.Match(decryptedMessage.ToString(), pattern);

            if (matchMessage.Success)
            {
                char behaviour = char.Parse(matchMessage.Groups["behaviour"].Value);

                if (behaviour == 'G')
                {
                    Console.WriteLine(matchMessage.Groups["name"].Value);
                }
            }

            decryptedMessage.Clear();
            message = Console.ReadLine();
        }
    }
}