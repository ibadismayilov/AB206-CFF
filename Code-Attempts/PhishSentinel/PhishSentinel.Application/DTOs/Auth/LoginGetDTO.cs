using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhishSentinel.Application.DTOs.Auth;
public class LoginGetDTO
{
    public string UsernameOrEmail { get; set; }
    public string Password { get; set; }
}
