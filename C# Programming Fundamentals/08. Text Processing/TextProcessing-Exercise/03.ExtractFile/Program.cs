internal class Program
{
    private static void Main(string[] args)
    {
        string[] filePath = Console.ReadLine().Split('\\');
        string[] fileInfo = filePath.Last().Split('.');

        string fileExtension = fileInfo.Last();
        string fileName = fileInfo.First();

        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"File extension: {fileExtension}");
    }
}