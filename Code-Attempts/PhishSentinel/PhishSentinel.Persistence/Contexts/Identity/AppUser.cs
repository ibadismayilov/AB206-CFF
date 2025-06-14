using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhishSentinel.Persistence.Identity;
public class AppUser : IdentityUser
{
    public string FullName { get; set; }

    // Gmail OAuth Access
    public string GoogleAccessToken { get; set; }   

    // Gmail Refresh Token
    public string GoogleRefreshToken { get; set; }

    // Token expiration time    
    public DateTime? TokenExpiryDate { get; set; }
}
