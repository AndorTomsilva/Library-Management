using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library
{
    // Represents a user of the library system.
    public class User
    {
        // Properties
        public string UserName { get; set; } // User's name
        public int Passcode { get; set; } // Unique identifier for the user

        // Constructor
        public User(string userName, int passcode)
        {
            UserName = userName;
            Passcode = passcode;
        }
        public bool IsValid()
        {
            return UserName == "Admin" && Passcode == 00123;
        }
    
    // Method to borrow an item from the library
    public void BorrowItem<T>(Library<T> library, Func<T, bool> predicate)
        {
            library.BorrowItem(predicate); // Call BorrowItem method of the Library<T> class
        }

        // Method to return an item to the library
        public void ReturnItem<T>(Library<T> library, Func<T, bool> predicate)
        {
            library.ReturnItem(predicate); // Call ReturnItem method of the Library<T> class
        }
    }
}
