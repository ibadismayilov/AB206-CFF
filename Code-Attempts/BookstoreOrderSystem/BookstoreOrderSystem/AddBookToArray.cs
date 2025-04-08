using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreOrderSystem;

public class AddBookToArray
{
    Books[] books = new Books[0];

    public void AddBook(Books book)
    {
        if (books.Length == 0)
        {
            Array.Resize(ref books, 1);
            books[0] = book;
            Console.WriteLine("Kitab yaradildi!");
        } else
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
            Console.WriteLine("Kitab yaradildi!");
        }
    }
}
