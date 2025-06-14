using Microsoft.AspNetCore.Identity;

namespace LessonOnionArc.Persistence.Contexts.Identity;

public class AppRole : IdentityRole
{
    public string Desc { get; set; }
}

