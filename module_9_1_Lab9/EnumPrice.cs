using Lab9;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class EnumPrice : IEnumerable, IEnumerator
    {
        int i = -1;
        Book[] data;
        internal EnumPrice(Book[] books) 
        {
            data = (Book[])books.Clone();
            Array.Sort(data, Book.ByPrice());
        }

        public object Current => data[i];
        public IEnumerator GetEnumerator() => this;
        public bool MoveNext()
        {
            i++;
            if (i < data.Length) return true;
            else return false;

        }
        public void Reset()
        {
            i = -1;
        }
    }
}
