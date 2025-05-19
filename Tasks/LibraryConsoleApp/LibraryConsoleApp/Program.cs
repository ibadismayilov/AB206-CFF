using LibraryConsoleApp;
using System;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Get Book by ID");
            Console.WriteLine("3. Remove Book");
            Console.WriteLine("4. Update Book");
            Console.WriteLine("5. Show All Books");
            Console.WriteLine("6. Search Book by Name");
            Console.WriteLine("0. Exit");
            Console.Write("Select: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Price: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Book book = new Book(name, author, price);
                    library.AddBook(book);
                    Console.WriteLine("Book added.");
                    break;

                case "2":
                    Console.Write("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Book b = library.GetBookById(id);
                    if (b != null)
                        b.ShowInfo();
                    else
                        Console.WriteLine("Book not found.");
                    break;

                case "3":
                    Console.Write("Enter ID to remove: ");
                    int removeId = Convert.ToInt32(Console.ReadLine());
                    library.RemoveBook(removeId);
                    break;

                case "4":
                    Console.Write("Enter ID to update: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("New Name: ");
                    string newName = Console.ReadLine();
                    Console.Write("New Author: ");
                    string newAuthor = Console.ReadLine();
                    Console.Write("New Price: ");
                    double newPrice = Convert.ToDouble(Console.ReadLine());
                    Book updatedBook = new Book(newName, newAuthor, newPrice);
                    library.UpdateBook(updateId, updatedBook);
                    break;

                case "5":
                    library.GetAllBooks();
                    break;

                case "6":
                    Console.Write("Enter book name: ");
                    string searchName = Console.ReadLine();
                    library.GetBooksByName(searchName);
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Wrong choice.");
                    break;
            }
        }
    }
}
