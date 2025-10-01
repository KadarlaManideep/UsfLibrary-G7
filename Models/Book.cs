using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsfLibrary_G7.Models
{
    public sealed class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public int AvailableCopies { get; private set; }

        public Book(string title, string author, string isbn, int availableCopies)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            AvailableCopies = availableCopies;
        }


        // Required by spec
        public bool BorrowBook()
        {
            if (AvailableCopies <= 0) return false;
            AvailableCopies--;
            return true;
        }

        public bool ReturnBook()
        {
            AvailableCopies++;
            return true;
        }

        public override string ToString()
            => $"Title: {Title}, Author: {Author}, Available Copies: {AvailableCopies}";
    }
}