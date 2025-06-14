using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybor2.DAL.Models;

public class AppUser: IdentityUser
{
    public string FulllName { get; set; }
}