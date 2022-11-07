using System;

namespace _05.MovieRatings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input:
            int countMovies = int.Parse(Console.ReadLine());

            // Estimating max, min and average movie rating:
            string movieMaxRating = string.Empty;
            string movieMinRating = string.Empty;

            double ratingMin = double.MaxValue;
            double ratingMax = double.MinValue;
            double ratingSum = 0;

            for (int i = 0; i < countMovies; i++)
            {
                string movieName = Console.ReadLine();
                double movieRating = double.Parse(Console.ReadLine());

                ratingSum += movieRating;
                if (movieRating > ratingMax)
                {
                    ratingMax = movieRating;
                    movieMaxRating = movieName;
                }
                if (movieRating < ratingMin)
                {
                    ratingMin = movieRating;
                    movieMinRating = movieName;
                }
            }

            // Output ratings:
            Console.WriteLine($"{movieMaxRating} is with highest rating: {ratingMax:F1}");
            Console.WriteLine($"{movieMinRating} is with lowest rating: {ratingMin:F1}");
            Console.WriteLine($"Average rating: {ratingSum / countMovies:F1}");
        }
    }
}
