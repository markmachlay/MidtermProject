using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermProject
{
    class ReturnBook
    {
        public List<Book> Return(List<Book> books, string input)
        {

            var resultsReturn = books.Where(book => book.Title.Equals(input, StringComparison.InvariantCultureIgnoreCase) || book.Author.Equals(input, StringComparison.InvariantCultureIgnoreCase)).ToList();


            foreach (var book in resultsReturn)
            {
                if (book.Title.Equals(input, StringComparison.InvariantCultureIgnoreCase) && book.InLibrary == BookStatus.Checked_Out || book.Author.Equals(input, StringComparison.InvariantCultureIgnoreCase) && book.InLibrary == BookStatus.Checked_Out)
                {
                    Console.WriteLine($"Thank you for returning {book.Title}");
                    book.InLibrary = BookStatus.On_Shelf;
                    book.DueDate = DateTime.Today;

                }
                else if(book.Title.Equals(input, StringComparison.InvariantCultureIgnoreCase) && book.InLibrary == BookStatus.Overdue || book.Author.Equals(input, StringComparison.InvariantCultureIgnoreCase) && book.InLibrary == BookStatus.Overdue)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Thank you for returning {book.Title}, it was {(DateTime.Today - book.DueDate).TotalDays}  days overdue");
                    book.InLibrary = BookStatus.On_Shelf;
                    book.DueDate = DateTime.Today;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if(book.Title.Equals(input, StringComparison.InvariantCultureIgnoreCase) && book.InLibrary == BookStatus.Lost || book.Author.Equals(input, StringComparison.InvariantCultureIgnoreCase) && book.InLibrary == BookStatus.Lost)
                {
                    Console.WriteLine($"Thank you for returning {book.Title}, we thought it lost");
                    book.InLibrary = BookStatus.On_Shelf;
                    book.DueDate = DateTime.Today;

                }
                else
                {
                    Console.WriteLine($"{book.Title} is not checked out, did you steal this book?");
                }
            }
            return resultsReturn;
        }
    }
}
