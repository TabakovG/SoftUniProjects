using System;
using System.Collections.Generic;
using System.Linq;

namespace Article2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articlesList = new List<Article>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] articleInput = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article article = new Article(articleInput[0], articleInput[1], articleInput[2]);
                articlesList.Add(article);

            }

            string sortBy = Console.ReadLine();
            List<Article> OrderedList = new List<Article>();

            switch (sortBy)
            {
                case "title":
                    OrderedList =  articlesList.OrderBy(a => a.Title).ToList();
                    break;
                case "content":
                    OrderedList = articlesList.OrderBy(a => a.Content).ToList();
                    break;
                case "author":
                    OrderedList = articlesList.OrderBy(a => a.Author).ToList();
                    break;
            }

            foreach (var article in OrderedList)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }

        }


    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Author = author;
            this.Content = content;
        }

    }
}
