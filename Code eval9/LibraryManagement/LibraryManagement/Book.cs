using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; private set; }
        public Book(string title, string author, string iSBN)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            IsBorrowed = false;
        }
        public void Borrow()
        {
            if(IsBorrowed)
            {
                throw new InvalidOperationException("Book already borrowed");
            }
            IsBorrowed=true;
        }
        public void Return()
        {
            IsBorrowed = false;
        }
    }
}
