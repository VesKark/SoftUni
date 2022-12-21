using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int operations = int.Parse(Console.ReadLine());
        Stack<string> textHistory = new Stack<string>();
        StringBuilder text = new StringBuilder();

        for (int i = 0; i < operations; i++)
        {
            string[] command = Console.ReadLine().Split();
            int operationNr = int.Parse(command[0]);

            if (operationNr == 1)
            {
                text.Append(command[1]);
                textHistory.Push(text.ToString());
            }
            else if (operationNr == 2)
            {
                int removeLength = int.Parse(command[1]);
                text.Remove(text.Length - removeLength, removeLength);
                textHistory.Push(text.ToString());
            }
            else if (operationNr == 3)
            {
                int index = int.Parse(command[1]);
                Console.WriteLine(text[index - 1]);
            }
            else if (operationNr == 4)
            {
                textHistory.Pop();

                if (textHistory.Count != 0)
                {
                    text = new StringBuilder(textHistory.Peek());
                }
                else
                {
                    text = new StringBuilder();
                }
            }
        }
    }
}