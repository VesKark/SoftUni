using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader words = new StreamReader(wordsFilePath))
            {
                string[] wordsArray = words.ReadLine().ToLower().Split();

                StreamReader text = new StreamReader(textFilePath);
                string readText = text.ReadToEnd().ToLower();

                string pattern = @"[a-zA-Z0-9\']+";
                MatchCollection allWords = Regex.Matches(readText, pattern);

                Dictionary<string, int> wordCounts = new Dictionary<string, int>();

                foreach (string searchedWord in wordsArray)
                {
                    int count = 0;

                    foreach (Match word in allWords)
                    {
                        string currWord = word.Value;

                        if (searchedWord == currWord)
                        {
                            count++;
                        }
                    }

                    wordCounts[searchedWord] = count;
                }

                using (StreamWriter countedWords = new StreamWriter(outputFilePath))
                {
                    foreach (var item in wordCounts.OrderByDescending(x => x.Value))
                    {
                        countedWords.WriteLine($"{item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
