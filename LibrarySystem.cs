using System;
using System.Collections.Generic;
 
namespace LibrarySystem
{
    public class Person
    {
        public string _name;
        public string _email;
        public string _id;
 
        public Person(string name, string email, string id)
        {
            _name = name;
            _email = email;
            _id = id;
        }
 
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {_name}, ID: {_id}");
        }
    }
 
    public class Student : Person
    {
        public string _major;
        public int _graduationyear;
 
        public Student(string name, string email, string id, string major, int graduationyear)
            : base(name, email, id)
        {
            _major = major;
            _graduationyear = graduationyear;
        }
    }
 
    public class Staff : Person
    {
        public string _position;
        public string _department;
 
        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            _position = position;
            _department = department;
        }
    }
 
    public class Book
    {
        public string _title;
        public string _author;
        public string _ISBN;
        public int _copies;
 
        public Book(string title, string author, string isbn, int copies)
        {
            _title = title;
            _author = author;
            _ISBN = isbn;
            _copies = copies;
        }
 
        public bool BorrowBook()
        {
            if (_copies > 0)
            {
                _copies--;
                return true;
            }
            return false;
        }
 
        public void ShowInfo()
        {
            Console.WriteLine($"Title: {_title}, Author: {_author}, Available Copies: {_copies}");
        }
    }
 
    public class Library
    {
        public List<Person> DisplayPatrons { get; set; }
        public List<Book> DisplayBooks { get; set; }
 
        public Library()
        {
            DisplayPatrons = new List<Person>();
            DisplayBooks = new List<Book>();
        }
 
        public void AddPatron(Person patron)
        {
            DisplayPatrons.Add(patron);
        }
 
        public void AddBook(Book book)
        {
            DisplayBooks.Add(book);
        }
 
        public void ShowAllPatrons()
        {
            foreach (var patron in DisplayPatrons)
            {
                patron.ShowInfo();
            }
        }
 
        public void ShowAllBooks()
        {
            foreach (var book in DisplayBooks)
            {
                book.ShowInfo();
            }
        }
 
        public void BorrowBook(Person patron, string bookTitle)
        {
            Book book = DisplayBooks.Find(b => b._title == bookTitle);
            if (book != null && book.BorrowBook())
            {
                Console.WriteLine($"{patron._name} borrowed '{book._title}'");
            }
            else
            {
                Console.WriteLine($"Sorry, '{bookTitle}' is not available.");
            }
        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            // Create books
            Book b1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book b2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book b3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);
 
            // Create students
            Student s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student s2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
 
            // Create staff
            Staff st1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
 
            // Create library and add books and patrons
            Library library = new Library();
            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);
            library.AddPatron(s1);
            library.AddPatron(s2);
            library.AddPatron(st1);
 
            // Display initial library information
            Console.WriteLine("Books in Library:");
            library.ShowAllBooks();
 
            Console.WriteLine("\nPatrons in Library:");
            library.ShowAllPatrons();
 
            // Borrow books
            Console.WriteLine("\nBorrowing Books...");
            library.BorrowBook(s2, "Business Insights with AI");
            library.BorrowBook(s1, "Analytics in Action");
 
            // Display updated library information
            Console.WriteLine("\nBooks after borrowing:");
            Console.WriteLine("Books in Library:");
            library.ShowAllBooks();
        }
    }
}