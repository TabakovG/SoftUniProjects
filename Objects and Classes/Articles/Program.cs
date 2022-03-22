using System;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInput = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(articleInput[0], articleInput[1], articleInput[2]);

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine().Split(": ");

                switch (command[0])
                {
                    case "Edit":
                        article.Edit(command[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(command[1]);
                        break;
                    case "Rename":
                        article.Rename(command[1]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

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

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newName)
        {
            this.Title = newName;
        }
    }
}
