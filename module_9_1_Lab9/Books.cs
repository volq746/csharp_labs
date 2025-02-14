using System;
using System.Collections;

namespace Lab9
{
    class Books 
    {
        Book[] books;
        public Books() { books = Book.TestBooks(); }
        public IEnumerator GetEnumerator() => books.GetEnumerator();
        public IEnumerable GetByAuthor() => new EnumAuthor(books);
        public IEnumerable GetByPrice() => new EnumPrice(books);
        public IEnumerable GetReverseEnum()
        {
            for (int i = books.Length - 1; i >= 0; --i)
                yield return books[i];
        }
    }
}
