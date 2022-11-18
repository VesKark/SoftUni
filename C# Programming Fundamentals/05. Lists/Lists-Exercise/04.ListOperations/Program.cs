using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentCommand = command.Split();
                string action = currentCommand[0];

                if (action == "Add")
                {
                    int num = int.Parse(currentCommand[1]);
                    numbers.Add(num);
                }
                else if (action == "Insert")
                {
                    int num = int.Parse(currentCommand[1]);
                    int index = int.Parse(currentCommand[2]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, num);
                    }
                }
                else if (action == "Remove")
                {
                    int index = int.Parse(currentCommand[1]);

                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(index);
                    }
                }
                else if (action == "Shift")
                {
                    string direction = currentCommand[1];
                    int moveSteps = int.Parse(currentCommand[2]);
                    // List<int> temp = new List<int>();

                    if (direction == "left")
                    {                        
                        for (int i = 0; i < moveSteps; i++)
                        {
                            int temp = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(temp);
                            // temp.Add(numbers[i]);
                        }
                        // numbers.RemoveRange(0, moveSteps);
                        // numbers.AddRange(temp);
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < moveSteps; i++)
                        {
                            int temp = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, temp);
                            // temp.Add(numbers[numbers.Count - 1 - i]);
                        }
                        // numbers.RemoveRange(numbers.Count - 1, moveSteps);
                        // numbers.InsertRange(0, temp);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
