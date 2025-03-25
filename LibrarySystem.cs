using System;
using System.Collections.Generic;


namespace LibrarySystem
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _ISBN;
        private int _copies;


        // Constructor to initialize the fields
        public Book(string title, string author, string isbn, int copies)
        {
            _title = title;   // Assigning values passed in the constructor to the private fields
            _author = author;
            _ISBN = isbn;
            _copies = copies;
        }

        // Public method to borrow book
        public bool BorrowBook()
        {
            if (_copies > 0)
            {
                _copies--;
                return true;
            }
            return false;
        }

        // Public method to return book
        public void ReturnBook()
        {
            _copies++;
        }

    }
  


namespace LibrarySystem
{
    public class Library
    {
        public List<Patron> DisplayPatrons { get; set; }
        public List<Book> DisplayBooks { get; set; }

        public Library()
        {
            DisplayPatrons = new List<Patron>();
            DisplayBooks = new List<Book>();
        }

        public void ShowAllPatrons()
        {
            Console.WriteLine("Library Patrons:");
            foreach (var patron in DisplayPatrons)
            {
                Console.WriteLine(patron);
            }
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("Library Books:");
            foreach (var book in DisplayBooks)
            {
                Console.WriteLine(book);
            }
        }
    }

}