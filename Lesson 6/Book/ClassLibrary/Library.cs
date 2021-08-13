using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Library
    {
        Book[] _books;

        public Library(Book[] books) { _books = books; }
      
        public Book[] Books { get { return _books; } }
        

        public Book BookIndex(int index) { return _books[index]; }
       

        public Book BookFinder(string bookName)
        {
            foreach (Book book in _books)
            {
                if (bookName == book.BookName)
                {
                    return book;
                }
            }
            return null;
        }
        


    }
}
