using System;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = Books.TestBooks;

            // Сериализация books
            XmlSerializer xml = new XmlSerializer(typeof(Book[]));
            using (FileStream sw = new FileStream(Path.Combine("..", "..", "..", "xmlfile.xlm"), FileMode.OpenOrCreate))
            {
                xml.Serialize(sw, books);
            }


            // Десериализация books
            using (StreamReader sr = new StreamReader(Path.Combine("..", "..", "..", "xmlfile.xlm")))
            {
                XmlSerializer xmlread = new XmlSerializer(typeof(Book[]));
                Book[]? books2 = xmlread.Deserialize(sr) as Book[];
                if (books2 != null)
                {
                    foreach (Book b in books2)
                    {
                        Console.WriteLine(b);
                    }
                }

            }


            Console.WriteLine("Ok");
        }
    }
}
