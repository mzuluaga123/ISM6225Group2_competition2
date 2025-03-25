using System;
using System.Collections.Generic;

namespace MyAPP
{
    // Base class: Person
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string ID { get; set; }

        public Person(string name, string email, string id)
        {
            Name = name;
            Email = email;
            ID = id;
        }
    }

    // Derived class: Student
    public class Student : Person
    {
        public string Major { get; set; }
        public int GraduationYear { get; set; }

        public Student(string name, string email, string id, string major, int gradYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = gradYear;
        }
    }

    // Derived class: Staff
    public class Staff : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }

        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            Position = position;
            Department = department;
        }
    }

    // Book class
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int AvailableCopies { get; set; }

        public Book(string title, string author, string isbn, int copies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            AvailableCopies = copies;
        }

        public bool BorrowBook()
        {
            if (AvailableCopies > 0)
            {
                AvailableCopies--;
                return true;
            }
            return false;
        }
    }

    // Library class
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Person> Patrons { get; set; } = new List<Person>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void AddPatron(Person person)
        {
            Patrons.Add(person);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
            }
            Console.WriteLine();
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (var patron in Patrons)
            {
                Console.WriteLine($"Name: {patron.Name}, ID: {patron.ID}");
            }
            Console.WriteLine();
        }

        public Book FindBookByTitle(string title)
        {
            return Books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create library instance
            Library usfLibrary = new Library();

            // Create books
            Book book1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Book book2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            Book book3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);

            usfLibrary.AddBook(book1);
            usfLibrary.AddBook(book2);
            usfLibrary.AddBook(book3);

            // Create students
            Student akhil = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            Student sandeep = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);

            // Create staff
            Staff grandon = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");

            usfLibrary.AddPatron(akhil);
            usfLibrary.AddPatron(sandeep);
            usfLibrary.AddPatron(grandon);

            // Display books before borrowing
            usfLibrary.DisplayBooks();

            // Display patrons
            usfLibrary.DisplayPatrons();

            // Borrow books
            Console.WriteLine("Borrowing Books...");

            Book bookToBorrow1 = usfLibrary.FindBookByTitle("Business Insights with AI");
            if (bookToBorrow1 != null && bookToBorrow1.BorrowBook())
            {
                Console.WriteLine("Sandeep borrowed 'Business Insights with AI'");
            }
            else
            {
                Console.WriteLine("Sandeep failed to borrow 'Business Insights with AI'");
            }

            Book bookToBorrow2 = usfLibrary.FindBookByTitle("Analytics in Action");
            if (bookToBorrow2 != null && bookToBorrow2.BorrowBook())
            {
                Console.WriteLine("Akhil borrowed 'Analytics in Action'");
            }
            else
            {
                Console.WriteLine("Akhil failed to borrow 'Analytics in Action'");
            }

            Console.WriteLine();

            // Display books after borrowing
            Console.WriteLine("Books after borrowing:");
            usfLibrary.DisplayBooks();
        }
    }
}
