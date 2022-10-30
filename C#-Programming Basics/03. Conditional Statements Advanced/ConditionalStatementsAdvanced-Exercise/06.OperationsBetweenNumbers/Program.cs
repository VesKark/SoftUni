using System;

namespace _06.OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine()); //"+", "-", "*", "/" or "%"

            // Operation:
            double operation = 0;

            switch (symbol)
            {
                case '/':                   
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        operation = num1 * 1.00 / num2;
                        Console.WriteLine($"{num1} {symbol} {num2} = {operation:F2}");
                    }
                    break;

                case '%': 
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        operation = num1 % num2;
                        Console.WriteLine($"{num1} {symbol} {num2} = {operation}");
                    }
                    break;
                    
                case '+':
                    operation = num1 + num2;
                    if (operation % 2 == 0)
                    {
                        Console.WriteLine($"{num1} {symbol} {num2} = {operation} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} {symbol} {num2} = {operation} - odd");
                    }
                    break;
                    
                case '-':
                    operation = num1 - num2;
                    if (operation % 2 == 0)
                    {
                        Console.WriteLine($"{num1} {symbol} {num2} = {operation} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} {symbol} {num2} = {operation} - odd");
                    }
                    break;
                    
                case '*':
                    operation = num1 * num2;
                    if (operation % 2 == 0)
                    {
                        Console.WriteLine($"{num1} {symbol} {num2} = {operation} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} {symbol} {num2} = {operation} - odd");
                    }
                    break;
            }                   
        }
    }
}
