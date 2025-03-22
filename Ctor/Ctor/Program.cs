namespace Ctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserModel userInformation = new UserModel("ibad@example.com", "secure123");
            Console.WriteLine(userInformation.email + "\n" + " " +userInformation.Password);
            Console.WriteLine(userInformation.Password = "4");
        }
    }
}
