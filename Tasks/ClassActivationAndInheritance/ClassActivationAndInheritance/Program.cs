using System.Security.Claims;
using System.Xml.Linq;

namespace ClassActivationAndInheritance;

internal class Program
{
    static void Main(string[] args)
    {

        InputValue user = new InputValue();

        Console.WriteLine(user.CheckInputValue());
        Console.WriteLine($"Name: {user.Name}\nSurname: {user.Surname}\nAge: {user.Age}\nEmail: {user.Email}\n");
    }
}   
