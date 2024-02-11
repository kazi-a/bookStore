using System;

namespace bookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating book objects
            Book book1 = new Book(); // Using default constructor
            book1.SetId(1);
            book1.SetTitle("The Great Gatsby");
            book1.SetAuthor("F. Scott Fitzgerald");

            Book book2 = new Book(); // Using default constructor with user input
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book2.SetAuthor(Console.ReadLine());

            Book book3 = new Book(2, "To Kill a Mockingbird", "Harper Lee"); // Using parameterized constructor

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string tempAuthor = Console.ReadLine();
            Book book4 = new Book(tempID, tempTitle, tempAuthor); // Using parameterized constructor with user input

            // Displaying book information
            DisplayBooks(book1);
            DisplayBooks(book2);
            DisplayBooks(book3);
            DisplayBooks(book4);
        }

        // Method to display book information
        static void DisplayBooks(Book book)
        {
            Console.WriteLine("Book ID: " + book.GetId());
            Console.WriteLine("Title: " + book.GetTitle());
            Console.WriteLine("Author: " + book.GetAuthor());
            Console.WriteLine();
        }
    }

    // Book class
    class Book
    {
        // Private fields
        private int _Id;
        private string _Title;
        private string _Author;

        // Default constructor
        public Book()
        {
        }

        // Parameterized constructor
        public Book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        // Get and Set methods for _Id field
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        // Get and Set methods for _Title field
        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        // Get and Set methods for _Author field
        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }
    }
}
