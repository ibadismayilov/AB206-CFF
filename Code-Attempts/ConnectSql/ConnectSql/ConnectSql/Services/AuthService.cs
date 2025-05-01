using ConnectSql.Contexts;
using ConnectSql.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectSql.Services
{
    public class AuthService
    {
        private readonly UserDbContext _context;

        public AuthService()
        {
            _context = new UserDbContext();
        }

        public void Register(User user)
        {
            var check = _context.Users.FirstOrDefault(item => item.Name == user.Name);

            if (check?.Name != user.Name)
            {
                _context.Users.Add(user);
                Console.WriteLine("Register is success");
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("User already exists");
            }
        }

        public bool Login(string name, int password)
        {
            var userInformation = _context.Users.FirstOrDefault(item => item.Name == name && item.Password == password);

            if (userInformation is not null)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("Information is wrong");
            }

            return false;
        }

        public List<User> GetAllUser()
        {
            return _context.Users.ToList();
        }
    }
}
