using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Core
{
    public class Library
    {
        public List<Book> Books { get; } = new();
        public List<Borrower> Borrowers { get; } = new();

        public void AddBook(Book book) => Books.Add(book);
        public void RegisterBorrower(Borrower borrower) => Borrowers.Add(borrower);

        public void BorrowBook(string isbn, string cardNumber)
        {
            var book = Books.First(b => b.ISBN == isbn);
            var borrower = Borrowers.First(b => b.LibraryCardNumber == cardNumber);
            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string cardNumber)
        {
            var book = Books.First(b => b.ISBN == isbn);
            var borrower = Borrowers.First(b => b.LibraryCardNumber == cardNumber);
            borrower.ReturnBook(book);
        }

        public IEnumerable<Book> ViewBooks() => Books;
        public IEnumerable<Borrower> ViewBorrowers() => Borrowers;
    }
}