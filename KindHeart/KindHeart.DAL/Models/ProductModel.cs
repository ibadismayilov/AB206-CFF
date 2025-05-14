using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindHeart.DAL.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string ImgFile { get; set; }
    [NotMapped]
    public IFormFile ImgPath { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public double Raised { get; set; }
    public double Goal { get; set; }
}
