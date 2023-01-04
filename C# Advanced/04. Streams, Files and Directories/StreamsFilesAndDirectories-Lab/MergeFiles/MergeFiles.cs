using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] firstInputLines = File.ReadAllLines(firstInputFilePath);
            string[] secondInputLines = File.ReadAllLines(secondInputFilePath);           
            
            int lines = Math.Max(firstInputLines.Length, secondInputLines.Length);

            Queue<string> allLines = new Queue<string>(firstInputLines.Length + secondInputLines.Length);

            for (int i = 0; i < lines; i++)
            {
                if (i < firstInputLines.Length)
                {
                    allLines.Enqueue(firstInputLines[i]);
                }

                if (i < secondInputLines.Length)
                {
                    allLines.Enqueue(secondInputLines[i]);
                }
            }  

            File.WriteAllLines(outputFilePath, allLines);
        }
    }
}
