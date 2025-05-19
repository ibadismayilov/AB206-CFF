using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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
    public string Category { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public int BedroomCount { get; set; }
    public int BathroomCount { get; set; }
    public int Area { get; set; }
    public int Floor { get; set; }
    public int Parking { get; set; }
}
