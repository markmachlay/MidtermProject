using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MidtermProject
{
    public class Book
    {
        public string Author { get; set; }

        public string Title { get; set; }

        public BookStatus InLibrary { get; set; }


        public DateTime DueDate { get; set; }

        public Book()
        {
        }
            

        public Book(string title , string author, BookStatus inLibrary, DateTime dueDate )
        {
            Title = title;
            Author = author;
            InLibrary = inLibrary;
            DueDate = dueDate;
            
        }


        public List<Book> DisplayLibrary()
        {
        
             var bookList = FileIO.ReadFromFile("CurrentBookList.txt");

            //OLD BOOK LIST DO NOT REMOVE AS IT MAY BE NEED LATER. 
            //List<Book> bookList = new List<Book>();
            //bookList.Add(new Book("Herman Melville", "Moby Dick", BookStatus.Overdue, test2));
            //bookList.Add(new Book("Bram Stoker", "Dracula", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("William Shakespeare", "Macbeth", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("Mary Shelley", "Frankenstein", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("Suzanne Collins", "Mockingjay", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("George Orwell", "1984", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("Stephenie Meyer", "Twilight", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("Stephen King", "Misery", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("Emma Donoghue", "Room", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("JRR Tolkien", "The Hobbit", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("James Joyce", "Ulysses", BookStatus.On_Shelf, test2));
            //bookList.Add(new Book("SE Hinton", "The Outsiders", BookStatus.On_Shelf, test2));

            return bookList;
        }
    }
}