using System;

namespace _05.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int smsSymbols = int.Parse(Console.ReadLine());
            int letterNumber = 0;

            for (int i = 1; i <= smsSymbols; i++)
            {
                int inputLetter = int.Parse(Console.ReadLine());
                int mainDigit = inputLetter % 10;

                if (mainDigit == 0)
                {
                    Console.Write(" ");
                    continue;
                }
                else if (mainDigit < 8)
                {
                    letterNumber = (mainDigit - 2) * 3 + inputLetter.ToString().Length;
                }
                else if (mainDigit >= 8)
                {
                    letterNumber = (mainDigit - 2) * 3 + inputLetter.ToString().Length + 1;
                }

                Console.Write((char)(letterNumber + 96));
            }            
        }
    }
}
