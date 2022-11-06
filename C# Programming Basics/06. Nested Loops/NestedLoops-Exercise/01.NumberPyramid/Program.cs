using System;

namespace _01.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());            
            int counter = 1;
            bool final = false;

            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {                    
                    if (counter > number)
                    {
                        final = true;
                        break;
                    }

                    Console.Write(counter + " ");
                    counter++;
                }

                if (final)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
