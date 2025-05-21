using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Scholar.MVC.ViewModels;

public class ProductVM
{
    [Required(ErrorMessage = "Moye More")]
    public IFormFile ImgFile { get; set; }
    [Required(ErrorMessage = "Moye More")]
    public string Category { get; set; }
    [Required(ErrorMessage = "Moye More")]
    public double Price { get; set; }
    [Required(ErrorMessage = "Moye More")]
    public string Title { get; set; }
    [Required(ErrorMessage = "fdfMoye More")]
    public string Desc { get; set; }
}
