using System;
using System.IO;

namespace OddLines
{	
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader inputFile = new StreamReader(inputFilePath))
            {
                string line = inputFile.ReadLine();
                int row = 0;

                using (StreamWriter outputFile = new StreamWriter(outputFilePath))
                {
                    while (line != null)
                    {
                        if (row % 2 != 0)
                        {
                            outputFile.WriteLine(line);
                        }

                        row++;
                        line = inputFile.ReadLine();
                    }
                }
            }
        }
    }
}
