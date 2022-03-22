using System;
using System.Collections.Generic;

namespace HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = $"<h1>\n{Console.ReadLine()}\n</h1>";
            string content = $"<article>\n{Console.ReadLine()}\n</article>";
            List<string> comments = new List<string>();

            string comment = Console.ReadLine();

            while (comment != "end of comments")
            {
                comments.Add(comment);

                comment = Console.ReadLine();
            }

            Console.WriteLine(title);
            Console.WriteLine(content);

            foreach (var item in comments)
            {
                Console.WriteLine($"<div>\n{item}\n</div>");
            }

        }
    }
}
