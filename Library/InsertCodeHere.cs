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

            // Step 2a
            Book aBook = new Book("ABC123", "Starting programming", "Peter Larsen", 59.95);

            // Step 2b
            aBook.PrintInformation();

            // Step 2c
            aBook.BorrowFromLibrary();
            aBook.PrintInformation();

            // Step 2d
            aBook.ReturnToLibrary();
            aBook.PrintInformation();


            // Step 4
            aBook.BorrowFromLibrary();
            aBook.ReturnToLibrary();
            aBook.BorrowFromLibrary();
            aBook.ReturnToLibrary();
            aBook.BorrowFromLibrary();
            aBook.ReturnToLibrary();
            aBook.BorrowFromLibrary();
            aBook.ReturnToLibrary();
            aBook.PrintInformation();

            // The LAST line of code should be ABOVE this line
        }
    }
}
