
using System;
using System.Collections.Generic;


namespace LibrarySystem
{
  public class Person
    {
        protected string _name;
        protected string _email;
        protected int _id;

        public Person(string name, string email, int id)
        {
            _name = name;
            _email = email;
            _id = id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {_name}, Email: {_email}, ID: {_id}");
        }
    }

    public class Student : Person
    {
        protected string _major;
        protected int _graduationyear;

        public Student(string name, string email, int id, string major, int graduationyear)
            : base(name, email, id)
        {
            _major = major;
            _graduationyear = graduationyear;
        }
    }

    public class Staff : Person
    {
        protected string _position;
        protected string _department;

        public Staff(string name, string email, int id, string position, string department)
            : base(name, email, id)
        {
            _position = position;
            _department = department;
        }
    }

    public class Patrons : Person
    {
        public Patrons(string name, int id)
            : base(name, "N/A", id)
        {
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Name: {_name}, ID: {_id}");
        }
    } 
  
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

