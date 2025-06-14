using LessonOnionArc.Application.Abstraction.Repositories.Auth;
using LessonOnionArc.Application.DTOs.Auth;
using LessonOnionArc.Persistence.Contexts.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application.Abstraction.Services.Auth;
public class AuthRepository : IAuthRepository
{
    public Task AddUserAsync(AppUser user)
    {
        throw new NotImplementedException();
    }

    public Task<AppUser?> GetUserByEmailAsync(string usernameOrEmail)
    {
        throw new NotImplementedException();
    }
}
