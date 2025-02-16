using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lab11
{
    class Book : IComparable
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return "id=" + Id + " price=" + Price + "$  " + Author + " : " + Title;
        }

        // IComparable
        public int CompareTo(Object? obj)
        {
            return (int)(this.Price - (obj as Book).Price);
        }

        class SortByAuthor : IComparer
        {
            public int Compare(Object x, Object y)
            {
                int res = 0;
                Book b1 = (Book)x;
                Book b2 = (Book)y;

                res = b1.Author.CompareTo(b2.Author);
                if (res == 0)
                {
                    res = (int)(b1.Price - b2.Price);
                }
                return res;
            }
        }

        public static IComparer ByAuthor()
        {
            return new SortByAuthor();
        }
    }
}
