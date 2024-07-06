using School_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

using System;

namespace School_Library
{
    // Program class that contains the main entry point of the library management system.
    class Program
    {
        // Main method, the entry point of the program.
        static void Main(string[] args)
        {
            Console.Write("Enter Username: ");
            string userName = Console.ReadLine();

            Console.Write("Enter Passcode: ");
            int passcode = Convert.ToInt32(Console.ReadLine());

            User user = new User(userName, passcode);

            if (!user.IsValid())
            {
                Console.WriteLine("Access denied. Invalid credentials.");
                return;
            }
            // Create a new library of books
            var library = new Library<Book>();

            // Create a new user
            
            // Loop to keep the program running until the user chooses to exit
            while (true)
            {
                // Display the main menu for the Library Management System
                Console.WriteLine("Hello, Welcome! to your \nLibrary Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. View Available Books");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                // Process the user's choice
                switch (choice)
                {
                    case "1":
                        // Option to add a book to the library
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter book author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter book ISBN: ");
                        string isbn = Console.ReadLine();
                        library.AddItem(new Book(title, author, isbn));
                        break;

                    case "2":
                        // Option to borrow a book from the library
                        Console.Write("Enter book ISBN to borrow: ");
                        string borrowIsbn = Console.ReadLine();
                        user.BorrowItem(library, b => b.ISBN == borrowIsbn);
                        break;

                    case "3":
                        // Option to return a book to the library
                        Console.Write("Enter book ISBN to return: ");
                        string returnIsbn = Console.ReadLine();
                        user.ReturnItem(library, b => b.ISBN == returnIsbn);
                        break;

                    case "4":
                        // Option to view available books in the library
                        library.ViewAvailableItems();
                        break;

                    case "5":
                        // Option to exit the program
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        // Invalid input handling
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}


