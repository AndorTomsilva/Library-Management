using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library

{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
        }

        public override string ToString()
        {
            return $"\nTitle: {Title}, \nAuthor: {Author}, \nISBN: {ISBN}, \nBorrowed: {IsBorrowed}";
        }
    }
}
