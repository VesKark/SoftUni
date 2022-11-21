using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<char, string> morseAlphabet = new Dictionary<char, string>()
        {
            { 'A', ".-" },
            { 'B', "-..." },
            { 'C', "-.-." },
            { 'D', "-.." },
            { 'E', "." },
            { 'F', "..-." },
            { 'G', "--." },
            { 'H', "...." },
            { 'I', ".." },
            { 'J', ".---" },
            { 'K', "-.-" },
            { 'L', ".-.." },
            { 'M', "--" },
            { 'N', "-." },
            { 'O', "---" },
            { 'P', ".--." },
            { 'Q', "--.-" },
            { 'R', ".-." },
            { 'S', "..." },
            { 'T', "-" },
            { 'U', "..-" },
            { 'V', "...-" },
            { 'W', ".--" },
            { 'X', "-..-" },
            { 'Y', "-.--" },
            { 'Z', "--.." },
        };

        string[] morseCode = Console.ReadLine().Split();
        StringBuilder readCode = new StringBuilder();

        for (int i = 0; i < morseCode.Length; i++)
        {
            string currCode = morseCode[i];

            if (currCode == "|")
            {
                readCode.Append(" ");
                continue;
            }

            char codeLetter = morseAlphabet.Where(x => x.Value == currCode).Select(x => x.Key).FirstOrDefault();
            readCode.Append(codeLetter);
        }

        Console.WriteLine(readCode.ToString());
    }
}