using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    public bool IsAvailable { get; set; } = true;
    private double _price;

    public double Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Qiymət mənfi ola bilməz!");
                Console.WriteLine("Please again enter price");
                Price = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                _price = value;
            }
        }
    }

    public Book(string title, string author, int pageCount, double price)
    {
        Title = title;
        Author = author;
        PageCount = pageCount;
        Price = price;
    }

    public void BorrowBook()
    {
        if (!IsAvailable)
        {
            Console.WriteLine("Bu kitab hazırda mövcud deyil");
        }
        else
        {
            IsAvailable = false;
        }
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Page Count: {PageCount}");
        Console.WriteLine($"Price: {Price} AZN");
        Console.WriteLine($"Available: {(IsAvailable ? "Yes" : "No")}");
    }
}
class InputFieldValue : Book
{
    public InputFieldValue() : base("", "", 0, 0) { }

    public void GetInputValue()
    {
        Console.WriteLine("Please enter Title:");
        Title = Console.ReadLine();

        Console.WriteLine("Please enter Author:");
        Author = Console.ReadLine();

        Console.WriteLine("Please enter Page Count:");
        PageCount = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter Price:");
        Price = Convert.ToDouble(Console.ReadLine());
    }
}

