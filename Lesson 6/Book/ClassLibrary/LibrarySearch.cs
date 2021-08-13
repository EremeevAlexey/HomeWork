using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class LibrarySeach
    {
        public static Book FatBook(this Library library)
        {
            Book mostFatBook = library.Books[0];
            for (int i = 1; i < library.Books.Length; i++)
            {
                if (mostFatBook.FullPages < library.Books[i].FullPages)
                {
                    mostFatBook = library.Books[i];
                }
            }
            return mostFatBook;
        }

        
    }
}
