using ConnectSql.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectSql.Models
{
    public class Menu
    {
        public void StartApplication()
        {

            int result;

            AuthService authService = new AuthService();
            User user = new User();

            do
            {
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Get All User");
                Console.WriteLine("0. Logout Application");

                bool isCheck = int.TryParse(Console.ReadLine(), out result);

                if (isCheck)
                {
                    switch (result)
                    {
                        case 1:
                            Console.Write("Please enter a name: ");
                            user.Name = Console.ReadLine();

                            Console.Write("Please enter a password: ");
                            user.Password = Convert.ToInt32(Console.ReadLine());

                            authService.Register(user);

                            break;
                        case 2:
                            Console.Write("Please enter a name: ");
                            user.Name = Console.ReadLine();

                            Console.Write("Please enter a password: ");
                            user.Password = Convert.ToInt32(Console.ReadLine());

                            bool check = authService.Login(user.Name, user.Password);

                            if (check)
                            {
                                Console.WriteLine("Login success");
                            }

                            break;
                        case 3:
                            var getAllUser = authService.GetAllUser();
                            foreach (var item in getAllUser)
                            {
                                Console.WriteLine($"Name: {item.Name}");
                            }
                            break;
                        case 0:
                            Console.WriteLine("Logged...");
                            break;
                    }
                }
            }
            while (result != 0);
        }

    }
}
