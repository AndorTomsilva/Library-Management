using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Library
{
    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void BorrowItem<T>(Library<T> library, Func<T, bool> predicate)
        {
            library.BorrowItem(predicate);
        }

        public void ReturnItem<T>(Library<T> library, Func<T, bool> predicate)
        {
            library.ReturnItem(predicate);
        }
    }
}
