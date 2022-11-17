using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input integer array:
            int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArray = command.Split();

                // 1. Exchange function:
                if (commandArray[0] == "exchange")
                {
                    int index = int.Parse(commandArray[1]);

                    if (index < 0 || index >= intArray.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ExchangeAtIndex(index, intArray);
                    }
                }

                // 2. Index of Max even/odd function:
                if (commandArray[0] == "max")
                {
                    bool maxEven = true;
                    if (commandArray[1] == "odd")
                    {
                        maxEven = false;
                    }
                    FindMaxIndex(maxEven, intArray);
                }

                // 3. Index of Min even/odd function:
                if (commandArray[0] == "min")
                {
                    bool minEven = true;
                    if (commandArray[1] == "odd")
                    {
                        minEven = false;
                    }
                    FindMinIndex(minEven, intArray);
                }

                // 4. First n-even/odd elements:
                if (commandArray[0] == "first")
                {
                    int count = int.Parse(commandArray[1]);
                    bool isEven = true;
                    if (commandArray[2] == "odd")
                    {
                        isEven = false;
                    }

                    if (count < 0 || count > intArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        FirstNvalues(count, isEven, intArray);
                    }
                }

                // 5. Last n-even/odd elements:
                if (commandArray[0] == "last")
                {
                    int count = int.Parse(commandArray[1]);
                    bool isEven = true;
                    if (commandArray[2] == "odd")
                    {
                        isEven = false;
                    }

                    if (count < 0 || count > intArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        LastNvalues(count, isEven, intArray);
                    }
                }

                command = Console.ReadLine();
            }

            // Output final array:
            Console.Write("[");
            Console.Write(string.Join(", ", intArray));
            Console.Write("]");
        }

        static void ExchangeAtIndex(int index, int[] array)
        {
            int[] leftSide = new int[index + 1];
            int[] rightSide = new int[array.Length - leftSide.Length];

            for (int i = 0; i < leftSide.Length; i++)
            {
                leftSide[i] = array[i];
            }
            for (int i = 0; i < rightSide.Length; i++)
            {
                rightSide[i] = array[i + index + 1];
            }

            // exchanging sides:
            int countLeft = 0;
            int temp = array[index];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < rightSide.Length)
                {
                    array[i] = rightSide[i];
                }
                else
                {
                    array[i] = leftSide[countLeft];
                    countLeft++;
                }
            }
        }

        static void FindMaxIndex(bool searchEven, int[] array)
        {
            int max = int.MinValue;
            int bestIndex = -1;

            if (searchEven)
            {               
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] >= max)
                    {
                        max = array[i];
                        bestIndex = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] >= max)
                    {
                        max = array[i];
                        bestIndex = i;
                    }
                }
            }

            // print result:
            if (bestIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);
            }
        }

        static void FindMinIndex(bool searchEven, int[] array)
        {
            int min = int.MaxValue;
            int bestIndex = -1;

            if (searchEven)
            {                
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && array[i] <= min)
                    {
                        min = array[i];
                        bestIndex = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && array[i] <= min)
                    {
                        min = array[i];
                        bestIndex = i;
                    }
                }
            }

            // print result:
            if (bestIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(bestIndex);
            }
        }

        static void FirstNvalues(int count, bool searchEven, int[] array)
        {
            int[] output = new int[count];
            int countIndex = 0;

            if (searchEven)
            {   
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (count == countIndex)
                        {
                            break;
                        }
                        output[countIndex] = array[i];
                        countIndex++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (count == countIndex)
                        {
                            break;
                        }
                        output[countIndex] = array[i];
                        countIndex++;
                    }
                }
            }

            // print result:
            Console.Write("[");
            if (countIndex != 0)
            {
                for (int i = 0; i < countIndex - 1; i++)
                {
                    Console.Write(output[i] + ", ");
                }
                Console.Write(output[countIndex - 1]);
            }
            Console.WriteLine("]");            
        }

        static void LastNvalues(int count, bool searchEven, int[] array)
        {
            int[] output = new int[count];
            int countIndex = count;

            if (searchEven)
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0)
                    {
                        if (countIndex == 0)
                        {
                            break;
                        }
                        output[countIndex - 1] = array[i];
                        countIndex--;                        
                    }
                }
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0)
                    {
                        if (countIndex == 0)
                        {
                            break;
                        }
                        output[countIndex - 1] = array[i];
                        countIndex--;                        
                    }
                }
            }

            // print result:
            Console.Write("[");
            if (countIndex != count)
            {
                for (int i = countIndex; i < count - 1; i++)
                {
                    Console.Write(output[i] + ", ");
                }
                Console.Write(output[count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
