using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application.DTOs.Auth;

public class RegisterDTO
{
    public string FullName { get; set; }
    public string Email { get; set; }

    public string Password { get; set; }
    public string ConfirmPassword { get; set; }
}
