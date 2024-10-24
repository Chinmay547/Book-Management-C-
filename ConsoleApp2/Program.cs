using System;
using System.Collections.Generic;

class Program
{
    static List<Book> books = new List<Book>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Book Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View Books");
            Console.WriteLine("3. Update Book");
            Console.WriteLine("4. Delete Book");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ViewBooks();
                    break;
                case "3":
                    UpdateBook();
                    break;
                case "4":
                    DeleteBook();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }

    static void AddBook()
    {
        Console.Write("Enter book title: ");
        string title = Console.ReadLine();
        Console.Write("Enter book author: ");
        string author = Console.ReadLine();
        books.Add(new Book { Title = title, Author = author });
        Console.WriteLine("Book added successfully!");
    }

    static void ViewBooks()
    {
        Console.WriteLine("Books List:");
        foreach (var book in books)
        {
            Console.WriteLine($"- {book.Title} by {book.Author}");
        }
    }

    static void UpdateBook()
    {
        Console.Write("Enter the title of the book to update: ");
        string title = Console.ReadLine();
        var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            Console.Write("Enter new title: ");
            book.Title = Console.ReadLine();
            Console.Write("Enter new author: ");
            book.Author = Console.ReadLine();
            Console.WriteLine("Book updated successfully!");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    static void DeleteBook()
    {
        Console.Write("Enter the title of the book to delete: ");
        string title = Console.ReadLine();
        var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book deleted successfully!");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}
