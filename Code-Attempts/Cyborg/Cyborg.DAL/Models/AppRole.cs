using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyborg.DAL.Models;

public class AppRole :IdentityRole
{
    public string Role { get; set; }
}
