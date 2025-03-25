
using System;
using System.Collections.Generic;

namespace MyApp
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