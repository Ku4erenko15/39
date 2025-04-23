using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class FictionBook:IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public FictionBook(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
        }

        public string TitleInfo()
        {
            return Title;
        }

        public string AuthorInfo()
        {
            return Author;
        }

        public string Info()
        {
            return $"Название: {Title}, Автор: {Author}, Жанр: {Genre}";
        }
    }
}
