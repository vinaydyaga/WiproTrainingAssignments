using LibraryManagement;
using LibraryManagementSystem;
using NUnit.Framework;

namespace LibraryManagementSystem.Tests
{
    [TestFixture]
    public class LibraryTests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void AddBook_ShouldAddBookSuccessfully()
        {
            var book = new Book("C# Basics", "John", "123");

            library.AddBook(book);

            Assert.That(library.Books.Count, Is.EqualTo(1));
        }

        [Test]
        public void RegisterBorrower_ShouldRegisterSuccessfully()
        {
            var borrower = new Borrower("Vinay", "001");

            library.RegisterBorrower(borrower);

            Assert.That(library.Borrowers.Count, Is.EqualTo(1));
        }

        [Test]
        public void BorrowBook_ShouldMarkBookAsBorrowed_AndAssociateWithBorrower()
        {
            var book = new Book("C#", "John", "123");
            var borrower = new Borrower("Vinay", "001");

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("123", "001");

            Assert.That(book.IsBorrowed, Is.True);
            Assert.That(borrower.BorrowedBooks.Count, Is.EqualTo(1));
        }

        [Test]
        public void ReturnBook_ShouldMakeBookAvailable_AndRemoveFromBorrower()
        {
            var book = new Book("C#", "John", "123");
            var borrower = new Borrower("Vinay", "001");

            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("123", "001");

            library.ReturnBook("123", "001");

            Assert.That(book.IsBorrowed, Is.False);
            Assert.That(borrower.BorrowedBooks.Count, Is.EqualTo(0));
        }
    }
}