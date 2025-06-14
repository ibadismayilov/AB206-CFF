using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Makan.DAL.Enums.HumanGender;

namespace Makan.DAL.Model;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public int Password { get; set; }
    public bool IsLogin { get; set; } = false;
    public Genders Gender { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
