using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> allArticles = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] currArticle = Console.ReadLine().Split(", ");
                Article newArticle = new Article(currArticle[0], currArticle[1], currArticle[2]);
                allArticles.Add(newArticle);
            }

            string parameter = Console.ReadLine();

            if (parameter == "title")
            {
                allArticles = allArticles.OrderBy(x => x.Title).ToList();
            }
            else if (parameter == "content")
            {
                allArticles = allArticles.OrderBy(x => x.Content).ToList();
            }
            else if (parameter == "author")
            {
                allArticles = allArticles.OrderBy(x => x.Author).ToList();
            }   

            foreach (Article article in allArticles)
            {
                Console.WriteLine(article);
            }
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
