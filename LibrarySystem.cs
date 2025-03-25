
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
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            Console.WriteLine();
        }
    }
}