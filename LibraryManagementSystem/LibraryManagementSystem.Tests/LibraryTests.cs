using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementSystem.Core;
using System.Linq;

namespace LibraryManagementSystem.Tests
{
    [TestClass]
    public class LibraryTests
    {
        private Library library;

        [TestInitialize]
        public void Setup()
        {
            library = new Library();
        }

        [TestMethod]
        public void AddBook_ShouldAddBook()
        {
            library.AddBook(new Book("Clean Code", "Robert Martin", "ISBN1"));
            Assert.AreEqual(1, library.Books.Count);
        }

        [TestMethod]
        public void BorrowBook_ShouldMarkBorrowed()
        {
            var book = new Book("C#", "Jon Skeet", "ISBN2");
            var borrower = new Borrower("Alice", "CARD1");
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("ISBN2", "CARD1");

            Assert.IsTrue(book.IsBorrowed);
        }
    }
}