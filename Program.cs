using School_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace School_Library
{
        class Program
        {
            static void Main(string[] args)
            {
                var library = new Library<Book>();
                var user = new User("Alice");

                while (true)
                {
                    Console.WriteLine("\nLibrary Management System");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. Borrow Book");
                    Console.WriteLine("3. Return Book");
                    Console.WriteLine("4. View Available Books");
                    Console.WriteLine("5. Exit");
                    Console.Write("Choose an option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter book title: ");
                            string title = Console.ReadLine();
                            Console.Write("Enter book author: ");
                            string author = Console.ReadLine();
                            Console.Write("Enter book ISBN: ");
                            string isbn = Console.ReadLine();
                            library.AddItem(new Book(title, author, isbn));
                            break;

                        case "2":
                            Console.Write("Enter book ISBN to borrow: ");
                            string borrowIsbn = Console.ReadLine();
                            user.BorrowItem(library, b => b.ISBN == borrowIsbn);
                            break;

                        case "3":
                            Console.Write("Enter book ISBN to return: ");
                            string returnIsbn = Console.ReadLine();
                            user.ReturnItem(library, b => b.ISBN == returnIsbn);
                            break;

                        case "4":
                            library.ViewAvailableItems();
                            break;

                        case "5":
                            Console.WriteLine("Exiting...");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
    }

