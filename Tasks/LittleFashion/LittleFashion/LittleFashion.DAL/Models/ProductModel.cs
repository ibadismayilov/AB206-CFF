using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace LittleFashion.BL.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string Category { get; set; }
    public string ImgPath { get; set; }
    [NotMapped]
    public IFormFile ImgFile { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }

}
