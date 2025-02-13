using System;
using System.Collections;

namespace Lab9
{
    class Books 
    {
        Book[] books;
        public Books() { books = Book.TestBooks(); }
        public IEnumerator GetEnumerator() { return books.GetEnumerator(); }
        public IEnumerable GetByAuthor()
        {
            return new EnumAuthor(books);
        }
        public IEnumerable GetByPrice()
        {
            return new EnumPrice(books);
        }

    }
}
