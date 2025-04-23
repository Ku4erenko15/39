using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Program
    {
        static void Main(string[] args)
        {
            FictionBook fictionBook = new FictionBook("Преступление и наказание", "Фёдор Достоевский", "Роман");
            NonFictionBook nonFictionBook = new NonFictionBook("Теория относительности", "Альберт Эйнштейн", "Физика");
            Textbook textbook = new Textbook("Физика для школьников", "Юрий Кузнецов", "Физика");

            Library library = new Library();

            library.AddBook(fictionBook);
            library.AddBook(nonFictionBook);
            library.AddBook(textbook);

            library.DisplayBooks();
            Console.ReadKey();
        }
    }
}
