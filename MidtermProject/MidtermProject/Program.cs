using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
namespace MidtermProject
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.BackgroundColor = ConsoleColor.;
            Console.ForegroundColor = ConsoleColor.White;
            string continueFlag;
            Console.WriteLine("Welcome to our Library, We are happy you are here!");

            var libraryName = "CurrentBookList.txt";

            //For Reading from a file

            var books = FileIO.ReadFromFile(libraryName);



            //For Creating a File

            //var library = new Book();
            //var books = library.DisplayLibrary();
            //FileIO.CreateFile(libraryName);


            do
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\rHere are the books that we have in our Library:\n\r");   

                foreach (var book in books)
                {
                    Console.WriteLine($"{book.Title} by {book.Author}");
                }

                Console.WriteLine("\n\rThere are a few things you can do here:\n\r");
                Console.WriteLine("1. Checkout a book");
                Console.WriteLine("2. Return a book\n\r");
                //Console.WriteLine("3. Add a book to the library\n\r");

                Console.WriteLine("Please choose a number");
                var uI = new UserInput();
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    string searchAuthor = uI.GetUserInput("Please enter the name of a book or an Author:");
                    var searchMethod = new SearchMethod();
                    var searchedBooks = searchMethod.Titles(books, searchAuthor);
                }
                else if (userInput == "2")
                {
                    string searchAuthor2 = uI.GetUserInput("Please enter the name of the book you are returning:");
                    var returnBook = new ReturnBook();
                    var returnbooks = returnBook.Return(books, searchAuthor2);
                }
                //else if (userInput == "3")
                //{
                //    Console.WriteLine("Work in Progress");
                //}
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("THAT IS NOT A VALID RESPONSE");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                var userInput1 = new UserInput();
                continueFlag = userInput1.DoYouWantToContinue();

               

               static void SetToOverdue(List<Book> Book)
                {

                    //var test = new Book();

                    foreach (var book in Book)
                    {
                        if (book.DueDate <= DateTime.Today && book.InLibrary == BookStatus.Checked_Out)
                        {
                            book.InLibrary = BookStatus.Overdue;


                        }
                    }

                    

                }

                //var example = BookStatus.Overdue;

                SetToOverdue(books);

                //if ( test.DueDate >= DateTime.Today &&  test.InLibrary == BookStatus.Checked_Out)
                //{
                //    var test2 = new Book();





                //}

                FileIO.UpdateFile(libraryName, books);
            } while (continueFlag == "y");

            FileIO.UpdateFile(libraryName, books);

        }



    }
}