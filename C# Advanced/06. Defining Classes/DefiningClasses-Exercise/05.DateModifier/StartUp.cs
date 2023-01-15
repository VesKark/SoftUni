using System;

namespace _05.DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string dateA = Console.ReadLine();
            string dateB = Console.ReadLine();

            DateModifier modifyDates = new DateModifier(dateA, dateB);
            Console.WriteLine(modifyDates.DateDiff());
        }
    }
}
