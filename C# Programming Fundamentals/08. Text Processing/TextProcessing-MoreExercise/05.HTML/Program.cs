using System;

public class Program
{
    public static void Main()
    {
        string articleTitle = Console.ReadLine();
        string articleContent = Console.ReadLine();
        string articleComment = Console.ReadLine();

        PrintAsHTML(articleTitle, "h1");
        PrintAsHTML(articleContent, "article");

        while (articleComment != "end of comments")
        {
            PrintAsHTML(articleComment, "div");
            articleComment = Console.ReadLine();
        }
    }

    public static void PrintAsHTML(string textInfo, string tag)
    {
        Console.WriteLine("<{0}>", tag);
        Console.WriteLine("\t" + textInfo);
        Console.WriteLine("</{0}>", tag);
    }
}