using Microsoft.AspNetCore.Identity;

namespace Cybor2.DAL.Models;

public class AppRole : IdentityRole
{
    public string Role { get; set; }
}

