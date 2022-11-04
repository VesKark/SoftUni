using System;

namespace _06.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input country name:
            string country = Console.ReadLine();
            string language = string.Empty;

            // Output spoken language:
            switch (country)
            {
                case "England":
                case "USA":
                    language = "English";
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    language = "Spanish";
                    break;
                default:
                    language = "unknown";
                    break;
            }

            Console.WriteLine(language);
        }
    }
}
