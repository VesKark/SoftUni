using System;
using System.Linq;

namespace _01.EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int stringsCount = int.Parse(Console.ReadLine());

            // Reading strings and estimating codes:
                    // 1) The code of each vowel multiplied by the string length
                    // 2) The code of each consonant divided by the string length
            int[] codes = new int[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                int currentSum = 0;                
                string currentString = Console.ReadLine();

                for (int j = 0; j < currentString.Length; j++)
                {
                    bool isConsonant = true;
                    char[] vowels = new char[10] { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

                    foreach (char item in vowels)
                    {                        
                        if (currentString[j] == item)
                        {
                            currentSum += currentString[j] * currentString.Length;
                            isConsonant = false;
                            break;
                        }                        
                    }

                    if (isConsonant)
                    {
                        currentSum += currentString[j] / currentString.Length;
                    }
                }
                codes[i] = currentSum;
            }

            // Sorting and printing codes in ascending order:
            Array.Sort(codes);
            foreach (int item in codes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
