using System;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml.Linq;

namespace ClassActivationAndInheritance;
class Person
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public byte Age { get; set; }

    public Person(string name)
    {
        Name = name;
    }
    public Person(string name, string surname) : this(name)
    {
        Surname = surname;
    }

    public Person(string name, string surname, byte age) : this(name, surname)
    {
        Age = age;
    }
}

class User : Person
{
    public string Email { get; set; }
    public string Password { get; set; }
    public User(string name, string surname, byte age, string email, string password) : base(name, surname, age)
    {
        Email = email;
        Password = password;
    }
}

class InputValue : User
{
    public InputValue() : base("", "", 0, "", "") { }
    public string CheckInputValue()
    {

        Console.Write("Please enter name: ");
        Name = Console.ReadLine();

        bool checkName = false;
        if (Name.Length < 6 || Name.Length > 25)
        {
            Console.WriteLine($"Message: {checkName}\n");

            Console.WriteLine("Please enter the correct name again: ");
            Password = Console.ReadLine();
        }
        else
        {
            checkName = true;
            Console.WriteLine($"Message: {checkName}\n");
        }

        Console.Write("Please enter surname: ");
        Surname = Console.ReadLine();

        Console.Write("Please enter age: ");
        Age = Convert.ToByte(Console.ReadLine());

        Console.Write("Please enter email: ");
        Email = Console.ReadLine();

        Console.Write("Please enter password: ");
        Password = Console.ReadLine();

        bool checkPassword = false;

        if (Password.Length < 8 || Password.Length > 25)
        {
            Console.WriteLine($"Message: {checkPassword}\n");

            Console.WriteLine("Please enter the correct password again: ");
            Password = Console.ReadLine();
        }
        else
        {
            checkPassword = true;
            Console.WriteLine($"Message: {checkPassword}\n");
        }

        return default;
    }
}
