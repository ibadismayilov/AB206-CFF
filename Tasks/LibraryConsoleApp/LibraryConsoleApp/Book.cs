using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp;

public class Book
{
    private static int _idCounter = 1;
    public int Id { get; private set; }
    public string Name;
    public string Author;
    public double Price;

    public Book(string name, string author, double price)
    {
        Id = _idCounter++;
        Name = name;
        Author = author;
        Price = price;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Author: {Author}, Price: {Price} AZN");
    }

    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Author: {Author}, Price: {Price} AZN";
    }
}
