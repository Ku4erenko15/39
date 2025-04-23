using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Library
    {
        private List<IBook> books = new List<IBook>();

        public void AddBook(IBook book)
        {
            books.Add(book);
        }

        public void RemoveBook(IBook book)
        {
            books.Remove(book);
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.TitleInfo()}");
                Console.WriteLine($"Author: {book.AuthorInfo()}");
                Console.WriteLine($"Info: {book.Info()}\n");
            }
        }

    }
}
