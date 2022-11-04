using System;

namespace _02.LastDigitInEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int lastDigit = inputNumber % 10;
            string digitInEnglish = "";
            
            switch (lastDigit)
            {
                case 1: digitInEnglish = "one"; break;
                case 2: digitInEnglish = "two"; break;
                case 3: digitInEnglish = "three"; break;
                case 4: digitInEnglish = "four"; break;
                case 5: digitInEnglish = "five"; break;
                case 6: digitInEnglish = "six"; break;
                case 7: digitInEnglish = "seven"; break;
                case 8: digitInEnglish = "eight"; break;
                case 9: digitInEnglish = "nine"; break;
                case 0: digitInEnglish = "zero"; break;
            }

            Console.WriteLine(digitInEnglish);
        }
    }
}
