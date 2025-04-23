using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39
{
    class Textbook:IBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Item { get; set; }
        
        public Textbook(string title, string author, string item)
        {
            Title = title;
            Author = author;
            Item = item;
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
            return $"Название: {Title}, Автор: {Author}, Тема: {Item}";
        }
    }
}
