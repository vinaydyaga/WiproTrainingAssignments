using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> Books { get; private set; }
        public List<Borrower> Borrowers { get; private set; }
        public Library()
        {
            Books = new List < Book > ();
            Borrowers = new List < Borrower > ();
        }
        public void AddBook(Book book)
        {
            Books.Add(book); 
        }
        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }
        public void BorrowBook(string isbn, string libraryCardNum)
        {
            var book=Books.FirstOrDefault(b => b.ISBN == isbn);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNum == libraryCardNum);
            if(book == null||borrower == null)
            {
                throw new ArgumentException("Invalid ISBN or Card Number");
            }
            borrower.BorrowBook(book);
        }
        public void ReturnBook(string isbn, string libraryCardNum)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn);
            var borrower = Borrowers.FirstOrDefault(b => b.LibraryCardNum == libraryCardNum);
            if( book == null || borrower == null) 
            {
                throw new ArgumentException("Invalid ISBN or Card Number");
            }
            borrower.ReturnBook(book);
        }
        public List<Book> viewBooks()
        {
            return Books; 
        }
        public List<Borrower> ViewBorrowers()
        {
            return Borrowers; 
        }
    }
}
