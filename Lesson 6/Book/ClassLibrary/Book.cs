using System;

namespace ClassLibrary
{
    public class Book
    {
        private string _bookName;
        private int _fullPageBook;
        private string _libraryHaveBook;
        


        public Book(string bookName, string libraryHaveBook, int fullPageBook)
        {
            _bookName = bookName;
            _fullPageBook = fullPageBook;
            _libraryHaveBook = libraryHaveBook;
        }
        public string BookName { get { return _bookName; } }
        public int FullPages { get { return _fullPageBook; } }
        public string LibraryHaveBook { get { return _libraryHaveBook; } }

    }
    

}











