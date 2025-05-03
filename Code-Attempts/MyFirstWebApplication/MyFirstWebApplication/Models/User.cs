using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApplication.Models;

public class User : BaseClass
{
    [Required]
    public string Email { get; set; }
    [Required]
    public int Password { get; set; }
}
