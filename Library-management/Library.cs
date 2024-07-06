using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;

namespace School_Library
{
    // Generic class representing a library that can hold items of type T.
    public class Library<T>
    {
        // Private field to hold the collection of items in the library.
        private List<T> items = new List<T>();

        // Constructor (default)
        public Library()
        {
            // Default constructor
        }

        // Method to add an item to the library.
        public void AddItem(T item)
        {
            items.Add(item); // Add the item to the list
            Console.WriteLine($"{typeof(T).Name} succesfully added to the library."); // Print confirmation message
        }

        // Method to borrow an item from the library based on a predicate.
        public void BorrowItem(Func<T, bool> predicate)
        {
            var item = items.FirstOrDefault(predicate); // Find the item based on the predicate
            if (item != null && item is Book book && !book.IsBorrowed)
            {
                // If item is found and is a book and not already borrowed
                book.IsBorrowed = true; // Mark the book as borrowed
                Console.WriteLine($"{typeof(T).Name} '{book.Title}' has been borrowed."); // Print confirmation message
            }
            else if (item == null)
            {
                // If item is not found
                Console.WriteLine($"{typeof(T).Name} not found."); // Print message
            }
            else
            {
                // If item is found but already borrowed
                Console.WriteLine($"{typeof(T).Name} is already borrowed."); // Print message
            }
        }

        // Method to return an item to the library based on a predicate.
        public void ReturnItem(Func<T, bool> predicate)
        {
            var item = items.FirstOrDefault(predicate); // Find the item based on the predicate
            if (item != null && item is Book book && book.IsBorrowed)
            {
                // If item is found and is a book and is borrowed
                book.IsBorrowed = false; // Mark the book as returned
                Console.WriteLine($"{typeof(T).Name} '{book.Title}' has been returned."); // Print confirmation message
            }
            else if (item == null)
            {
                // If item is not found
                Console.WriteLine($"{typeof(T).Name} not found."); // Print message
            }
            else
            {
                // If item is found but is not borrowed
                Console.WriteLine($"{typeof(T).Name} was not borrowed."); // Print message
            }
        }

        // Method to view available items (books) in the library.
        public void ViewAvailableItems()
        {
            var availableItems = items.Where(item => item is Book book && !book.IsBorrowed).ToList(); // Filter available books
            if (availableItems.Count > 0)
            {
                // If available items exist
                Console.WriteLine("Available Items:"); // Print header
                availableItems.ForEach(item => Console.WriteLine(item)); // Print each available book
            }
            else
            {
                // If no available items
                Console.WriteLine("No items are available."); // Print message
            }
        } 
    }
}

