using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace School_Library
{
    public class Library<T>
    {
       
        public Library()
        { }

        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
            Console.WriteLine($"{typeof(T).Name} added to the library.");
        }

        public void BorrowItem(Func<T, bool> predicate)
        {
            var item = items.FirstOrDefault(predicate);
            if (item != null && item is Book book && !book.IsBorrowed)
            {
                book.IsBorrowed = true;
                Console.WriteLine($"{typeof(T).Name} '{book.Title}' has been borrowed.");
            }
            else if (item == null)
            {
                Console.WriteLine($"{typeof(T).Name} not found.");
            }
            else
            {
                Console.WriteLine($"{typeof(T).Name} is already borrowed.");
            }
        }

        public void ReturnItem(Func<T, bool> predicate)
        {
            var item = items.FirstOrDefault(predicate);
            if (item != null && item is Book book && book.IsBorrowed)
            {
                book.IsBorrowed = false;
                Console.WriteLine($"{typeof(T).Name} '{book.Title}' has been returned.");
            }
            else if (item == null)
            {
                Console.WriteLine($"{typeof(T).Name} not found.");
            }
            else
            {
                Console.WriteLine($"{typeof(T).Name} was not borrowed.");
            }
        }

        public void ViewAvailableItems()
        {
            var availableItems = items.Where(item => item is Book book && !book.IsBorrowed).ToList();
            if (availableItems.Count > 0)
            {
                Console.WriteLine("Available Items:");
                availableItems.ForEach(item => Console.WriteLine(item));
            }
            else
            {
                Console.WriteLine("No items are available.");
            }
        }
    }
}
