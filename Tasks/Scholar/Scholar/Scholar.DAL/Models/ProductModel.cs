using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.DAL.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string ImgPath { get; set; }
    [NotMapped]
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
