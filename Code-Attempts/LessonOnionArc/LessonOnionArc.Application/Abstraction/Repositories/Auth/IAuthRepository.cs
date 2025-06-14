using LessonOnionArc.Application.DTOs.Auth;
using LessonOnionArc.Persistence.Contexts.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application.Abstraction.Repositories.Auth;
public interface IAuthRepository
{
    Task AddUserAsync(AppUser user);
    Task<AppUser?> GetUserByEmailAsync(string usernameOrEmail);
}
