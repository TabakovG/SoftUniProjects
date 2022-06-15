using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public List<Book> books { get; private set; }

        public Library(params Book[] books)
        {
            Array.Sort(books, new BookComparator());
            this.books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        class LibraryIterator : IEnumerator<Book>
        {
            public List<Book> books { get; private set; }
            public int currentIndex { get; private set; } = -1;

            public LibraryIterator(List<Book> books)
            {
                this.books = new List<Book>(books);
            }

            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                currentIndex++;
                if (currentIndex >= books.Count)
                {
                    return false;
                }
                return true;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
    }
}
