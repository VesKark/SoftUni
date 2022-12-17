using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        Stack<char> reverseString = new Stack<char>();

        for (int i = 0; i < text.Length; i++)
        {
            reverseString.Push(text[i]);
        }

        Console.WriteLine(string.Join("", reverseString));
    }
}
