using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreOrderSystem;

public class Books
{
    public int BookId { get; set; }

    private static int _nextId = 1;

    public Books()
    {
        BookId = _nextId++;
    }

    public string Title { get; set; }
    public string Author { get; set; }
    public int Price { get; set; }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"ID: {BookId}\nBook Title: {Title}\nAuthor: {Author}\nPrice: {Price}");
    }
}
