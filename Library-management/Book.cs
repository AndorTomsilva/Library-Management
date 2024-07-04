using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library
{
    // Define the Book class to represent a book in the library
    public class Book
    {
        // Properties to store the book's title, author, ISBN, and borrowed status
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; set; }

        // Constructor to initialize a new book with the given title, author, and ISBN
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false; // Default borrowed status is false (not borrowed)
        }

        // Override the ToString method to provide a string representation of the book
        public override string ToString()
        {
            // Return the book details formatted as a string
            return $"\nTitle: {Title}, \nAuthor: {Author}, \nISBN: {ISBN}, \nBorrowed: {IsBorrowed}";
        }
    }
}
