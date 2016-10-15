using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Book aBook = new Book("123456789", "Basic Programming", "Sharp", 8.99);
            Book bBook = new Book("456789123", "Advanced Programming", "Bear", 19.95);
            Book cBook = new Book("789123456", "Ultimate Programming", "Larman", 18.95);

            aBook.PrintInformation();
            bBook.PrintInformation();
            cBook.PrintInformation();

            aBook.BorrowFromLibrary();

            aBook.PrintInformation();

            


            // The LAST line of code should be ABOVE this line
        }
    }
}
