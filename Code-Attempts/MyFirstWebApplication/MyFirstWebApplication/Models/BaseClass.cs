using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApplication.Models;

public abstract class BaseClass
{
    public int Id { get; set; }
    public string Name { get; set; }
}
