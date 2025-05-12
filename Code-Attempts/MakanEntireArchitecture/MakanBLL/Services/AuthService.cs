using Makan.DAL.Contexts;
using Makan.DAL.Migrations;
using Makan.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakanBLL.Services;

public class AuthService
{
    private readonly AppDbContext _context;

    public AuthService()
    {
        _context = new AppDbContext();
    }
    public bool RegisterFunction(RegisterViewModel registerViewModel)
    {
        var existingUser = _context.Users.FirstOrDefault(item => item.Username == registerViewModel.Username);
        if (existingUser is not null)
        {
            return false;
        }

        var user = new User
        {
            FullName = registerViewModel.FullName,
            Username = registerViewModel.Username,
            Email = registerViewModel.Email,
            PhoneNumber = registerViewModel.PhoneNumber,
            Gender = registerViewModel.Gender,
            Password = registerViewModel.Password,
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return true;
    }

    public bool LoginFunction(User user)
    {
        var existingUser = _context.Users.FirstOrDefault(item => item.Email == user.Email);


        if (existingUser is null)
        {
            return false;
        }

        if (!existingUser.Password.Equals(user.Password))
        {
            return false;
        }

        existingUser.IsLogin = true;
        return true;
    }

}
