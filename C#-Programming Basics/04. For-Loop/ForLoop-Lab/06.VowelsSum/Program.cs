using System;

namespace _06.VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char vow = ' ';
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                vow = input[i];
                switch (vow)
                {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
