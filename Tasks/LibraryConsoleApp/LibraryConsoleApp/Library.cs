using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp;
public class Library
{
    public string Name;
    public Book[] Books = new Book[0];

    public void AddBook(Book book)
    {
        Array.Resize(ref Books, Books.Length + 1);
        Books[Books.Length - 1] = book;
    }

    public Book GetBookById(int id)
    {
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Id == id)
                return Books[i];
        }
        return null;
    }

    public void RemoveBook(int id)
    {
        int index = -1;
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Id == id)
            {
                index = i;
                break;
            }
        }

        if (index == -1)
        {
            Console.WriteLine("kitab tapilmadi");
            return;
        }

        for (int i = index; i < Books.Length - 1; i++)
        {
            Books[i] = Books[i + 1];
        }

        Array.Resize(ref Books, Books.Length - 1);
        Console.WriteLine("kitab silindi");
    }

    public void GetBooksByName(string name)
    {
        bool found = false;
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Name.ToLower() == name.ToLower())
            {
                Books[i].ShowInfo();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("bu adda kitab tapilmadi");
    }

    public void GetAllBooks()
    {
        if (Books.Length == 0)
        {
            Console.WriteLine("libraryda bu kitab tapilmadi");
            return;
        }

        for (int i = 0; i < Books.Length; i++)
        {
            Books[i].ShowInfo();
        }
    }

    public void UpdateBook(int id, Book newBook)
    {
        for (int i = 0; i < Books.Length; i++)
        {
            if (Books[i].Id == id)
            {
                Books[i].Name = newBook.Name;
                Books[i].Author = newBook.Author;
                Books[i].Price = newBook.Price;
                Console.WriteLine("kitab updatee oldu");
                return;
            }
        }
        Console.WriteLine("kitab tapilmadi");
    }
}
