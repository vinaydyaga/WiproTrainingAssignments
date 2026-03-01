using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Borrower
    {
        public string Name { get; set; }
        public string LibraryCardNum { get; set; }
        public List<Book> BorrowedBooks { get; private set; }
        public Borrower(string name, string libraryCardNum)
        {
            Name = name;
            LibraryCardNum = libraryCardNum;
            BorrowedBooks = new List < Book>();
        }
        public void BorrowBook(Book book)
        {
            book.Borrow();
            BorrowedBooks.Add(book);
        }
        public void ReturnBook(Book book)
        {
            book.Return();
            BorrowedBooks.Remove(book);
        }
    }
}
