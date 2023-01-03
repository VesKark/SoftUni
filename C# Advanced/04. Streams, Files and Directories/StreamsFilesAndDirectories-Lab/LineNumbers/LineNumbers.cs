using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (StreamReader readInput = new StreamReader(inputFilePath))
            {
                string line = readInput.ReadLine();
                int row = 1;

                using (StreamWriter writeOutput = new StreamWriter(outputFilePath))
                {
                    while (line != null)
                    {
                        writeOutput.WriteLine($"{row}. {line}");
                        row++;
                        line = readInput.ReadLine();
                    }
                }
            }
        }
    }
}
