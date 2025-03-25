namespace Competition2___Inheritence;

class Program
{
    static void Main(string[] args)
    {
        Patrons p = new Patrons("Alice", 101);
        p.ShowInfo(); 

        Student s = new Student("Bob", "bob@email.com", 102, "CS", 2025);
        s.ShowInfo();

        Staff f = new Staff("Liliy", "1232@usf.edu", 007, "professor", "CS");
        f.ShowInfo();

        Console.ReadKey();
    }


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
}

