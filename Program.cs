using UsfLibrary_G7.Models;
using UsfLibrary_G7.Services;

namespace UsfLibrary_G7
{
    public class Program
    {
        public static void Main()
        {
            var lib = new Library();

            // --- Seed books ---
            var b1 = new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4);
            var b2 = new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3);
            var b3 = new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6);
            lib.AddBook(b1);
            lib.AddBook(b2);
            lib.AddBook(b3);

            // --- Seed patrons ---
            var s1 = new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", 2026);
            var s2 = new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", 2025);
            var staff1 = new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services");
            lib.AddPatron(s1);
            lib.AddPatron(s2);
            lib.AddPatron(staff1);

            // Display initial books
            lib.DisplayBooks();

            // Display patrons
            lib.DisplayPatrons();

            // Borrowing
            Console.WriteLine("Borrowing Books...");
            if (lib.Borrow("S002", "ISBN222", out var msg1))
                Console.WriteLine(msg1);
            else
                Console.WriteLine(msg1);

            if (lib.Borrow("S001", "ISBN333", out var msg2))
                Console.WriteLine(msg2);
            else
                Console.WriteLine(msg2);
            Console.WriteLine();

            // After borrowing
            Console.WriteLine("Books after borrowing:");
            lib.DisplayBooks();
        }
    }
}
