using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsfLibrary_G7.Models;

namespace UsfLibrary_G7.Services
{
    public sealed class Library
    {
        private readonly List<Book> _books = new();
        private readonly List<Person> _patrons = new();

        public void AddBook(Book book)
        {
            if (book is null) return;
            _books.Add(book);
        }

        public void AddPatron(Person person)
        {
            if (person is null) return;
            _patrons.Add(person);
        }

        public Book? FindBookByIsbn(string isbn)
            => _books.FirstOrDefault(b => b.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));

        public Person? FindPatronById(string id)
            => _patrons.FirstOrDefault(p => p.ID.Equals(id, StringComparison.OrdinalIgnoreCase));

        public bool Borrow(string patronId, string isbn, out string message)
        {
            var patron = FindPatronById(patronId);
            if (patron is null)
            {
                message = $"Patron with ID '{patronId}' not found.";
                return false;
            }

            var book = FindBookByIsbn(isbn);
            if (book is null)
            {
                message = $"Book with ISBN '{isbn}' not found.";
                return false;
            }

            if (!book.BorrowBook())
            {
                message = $"No copies available for '{book.Title}'.";
                return false;
            }

            message = $"{patron.Name} borrowed '{book.Title}'";
            return true;
        }

        public bool Return(string patronId, string isbn, out string message)
        {
            var patron = FindPatronById(patronId);
            if (patron is null)
            {
                message = $"Patron with ID '{patronId}' not found.";
                return false;
            }

            var book = FindBookByIsbn(isbn);
            if (book is null)
            {
                message = $"Book with ISBN '{isbn}' not found.";
                return false;
            }

            book.ReturnBook();
            message = $"{patron.Name} returned '{book.Title}'";
            return true;
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var b in _books)
            {
                Console.WriteLine($"Title: {b.Title}, Author: {b.Author}, Available Copies: {b.AvailableCopies}");
            }
            Console.WriteLine();
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (var p in _patrons)
            {
                Console.WriteLine($"Name: {p.Name}, ID: {p.ID}");
            }
            Console.WriteLine();
        }
    }
}
