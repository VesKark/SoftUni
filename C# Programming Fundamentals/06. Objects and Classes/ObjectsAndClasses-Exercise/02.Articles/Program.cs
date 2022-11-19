using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separator = new string[] { ", " };
            string[] input = Console.ReadLine().Split(separator, StringSplitOptions.None);
            Article article = new Article(input[0], input[1], input[2]);

            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                separator = new string[] { ": " };
                string[] currCommand = Console.ReadLine().Split(separator, StringSplitOptions.None);

                if (currCommand[0] == "Edit")
                {
                    article.Edit(currCommand[1]);
                }
                else if (currCommand[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(currCommand[1]);
                }
                else if (currCommand[0] == "Rename")
                {
                    article.Rename(currCommand[1]);
                }    
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }
        public void ChangeAuthor(string author)
        {
            Author = author;
        }
        public void Rename(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
