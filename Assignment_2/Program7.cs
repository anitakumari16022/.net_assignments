using System;
using System.Collections.Generic;

class Book
{
    public int BookID { get; set; }
    public string Title { get; set; }
    public bool IsAvailable { get; set; } = true;
}

class Member
{
    public int MemberID { get; set; }
    public string Name { get; set; }
}

class Library
{
    private List<Book> books = new List<Book>();
    private List<Member> members = new List<Member>();

    public void RegisterMember(Member m)
    {
        members.Add(m);
        Console.WriteLine($"Member '{m.Name}' registered successfully!");
    }

    public void AddBook(Book b)
    {
        books.Add(b);
        Console.WriteLine($"Book '{b.Title}' added to library.");
    }

    public void LendBook(int bookId, int memberId)
    {
        Book book = books.Find(b => b.BookID == bookId);
        Member member = members.Find(m => m.MemberID == memberId);

        if (book == null || member == null)
        {
            Console.WriteLine("Invalid book or member ID!");
            return;
        }

        if (book.IsAvailable)
        {
            book.IsAvailable = false;
            Console.WriteLine($"Book '{book.Title}' lent to '{member.Name}'.");
        }
        else
        {
            Console.WriteLine($"Book '{book.Title}' is currently not available.");
        }
    }

    public void ShowAvailableBooks()
    {
        Console.WriteLine("Available Books:");
        foreach (var book in books)
        {
            if (book.IsAvailable)
                Console.WriteLine($"BookID: {book.BookID}, Title: {book.Title}");
        }
    }
}

class Experiment7
{
    static void Main()
    {
        Library library = new Library();

        library.AddBook(new Book { BookID = 1, Title = "C# Programming" });
        library.AddBook(new Book { BookID = 2, Title = "OOP Concepts" });

        Member m1 = new Member { MemberID = 101, Name = "Alice" };
        library.RegisterMember(m1);

        library.ShowAvailableBooks();
        library.LendBook(1, 101);
        library.ShowAvailableBooks();
    }
}
