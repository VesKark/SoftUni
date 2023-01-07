using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            var files = Directory.GetFiles(folderPath);

            long sum = 0;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            var sumInMB = (sum / 1024.0) / 1024.0;

            File.WriteAllText(outputFilePath, sumInMB.ToString());
        }
    }
}
