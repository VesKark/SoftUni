using System;

namespace _10.Clock_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    for (int sec = 0; sec <= 59; sec++)
                    {
                        Console.WriteLine($"{hours} : {min} : {sec}");
                    }
                }
            }
        }
    }
}
