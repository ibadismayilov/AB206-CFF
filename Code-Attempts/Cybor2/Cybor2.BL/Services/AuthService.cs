using Cybor2.BL.ViewModels;
using Cybor2.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybor2.BL.Services;
public class AuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager
    public AuthService(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<string> Register(AuthCreateVM authCreateVM)
    {
        AppUser user = new AppUser();
        user.FulllName = authCreateVM.Fullname;
        user.Email = authCreateVM.Email;

        IdentityResult result = await _userManager.CreateAsync(user, authCreateVM.Password);

        if (!result.Succeeded)
        {
            var errors = result.Errors;
            string errorMessage = string.Empty;

            foreach (var item in errors)
            {
                errorMessage = errorMessage + item.Description + "\n";
            }
        }

        return "OK";
    }

    public async Task<string> Login(AuthCreateVM authCreateVM)
    {
      AppUser? user =  await _userManager.FindByEmailAsync(authCreateVM.Email);

     bool check =   await _userManager.CheckPasswordAsync(user, authCreateVM.Password);
        await _

        return "OK";
    }
}
