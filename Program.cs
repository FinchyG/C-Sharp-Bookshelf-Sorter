using System;
using System.Collections.Generic;

namespace BookshelfSorter
{
    class Program
    {
        static void Main()
        {
            UserData ud = new UserData();

            while (true)
            {
                Console.WriteLine("Press any key to add a book to your bookshelf or 'v' to view your bookshelf:");
                ud.Choice = Console.ReadLine().ToLower();

                if (ud.Choice == "v")
                    ud.DisplayBookshelf();
                
                else
                    ud.AddBook();
            }
        }
    }
}
