using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class NonFictionBook:IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string Theme { get; set; }


        public NonFictionBook(string title, string author, string theme)
        {
            Title = title;
            Author = author;
            Theme = theme;
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
            return $"Название: {Title}, Автор: {Author}, Жанр: {Theme}";
        }
    }
}
