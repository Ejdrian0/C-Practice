using System;

namespace Project
{
    class Book
    {
        private string? bookTitle;
        private string? bookAuthor;
        private int pageCount;

        public string Title
        {
            get { return bookTitle; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    bookTitle = value;
                else
                    Console.WriteLine("Name of the book cannot be empty!");
            }

        }

        public string Author
        {
            get { return bookAuthor; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    bookAuthor = value;
                else
                    Console.WriteLine("Name of the book author cannot be empty!");
            }

        }

        public int Pages
        {
            get { return pageCount; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Number of pages must be greater than 0");
                else
                    pageCount = value;
            }
        }

        public Book(string bookName, string bookAuthor, int bookPages) //Konstruktor
        {
            Title = bookName;
            Author = bookAuthor;
            Pages = bookPages;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}, Pages: {Pages}");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Chapter 10 - Classess and Objects\n");

            Book Book1 = new Book("Clean Code", "Robert C. Martin", 464);
            Book1.ShowInfo();
        }
    }
}
