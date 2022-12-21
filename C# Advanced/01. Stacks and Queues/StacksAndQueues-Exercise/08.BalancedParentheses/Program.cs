using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string parenthesis = Console.ReadLine();
        Stack<char> stackParenthesis = new Stack<char>();
        string[] balancedCases = new string[] { "{}", "[]", "()" };
        bool isBalanced = true;

        for (int i = 0; i < parenthesis.Length; i++)
        {
            char c = parenthesis[i];

            if (c == '{' || c == '[' || c == '(')
            {
                stackParenthesis.Push(c);
            }
            else if (c == '}' || c == ']' || c == ')')
            {
                if (stackParenthesis.Count == 0)
                {
                    isBalanced = false;
                    break;
                }

                char lastC = stackParenthesis.Peek();
                string checkCase = lastC + c.ToString();

                if (balancedCases.Contains(checkCase))
                {
                    stackParenthesis.Pop();
                }
                else
                {
                    isBalanced = false;
                    break;
                }
            }
        }

        if (isBalanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }    
    }
}