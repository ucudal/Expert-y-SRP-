using System;

namespace SRP
{
    public class Book
    {
        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
    public class ShelveBook
    {
        public string LibrarySector { get ;  }
        public string LibraryShelve { get ;  }
        public Book Book { get ; set; }
        public ShelveBook(String sector, String shelve, Book book)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
            this.Book = book;
        }
    }
}
