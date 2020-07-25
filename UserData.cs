using System;
using System.Collections.Generic;

namespace BookshelfSorter
{
    class UserData
    {
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        public string Choice { get; set; }

        public SortedDictionary<string, string> Bookshelf = new SortedDictionary<string, string>();

        public void DisplayBookshelf()
        {
            foreach (KeyValuePair<string, string> book in Bookshelf)
            {
                Console.WriteLine("{0}, by {1}", book.Key, book.Value);
            }
        }

        public void AddBook()
        {
            Console.WriteLine("What's the book's title?");
            BookTitle = Console.ReadLine();

            Console.WriteLine("Who's the book's author?");
            BookAuthor = Console.ReadLine();

            Bookshelf.Add(BookTitle, BookAuthor);
        }
    }
}
