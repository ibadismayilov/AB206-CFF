using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFT.DAL.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string ImgPath { get; set; }
    [NotMapped]
    public IFormFile ImgFile { get; set; }
    public string Title { get; set; }
    public int MinCount { get; set; }
    public int MaxCount { get; set; }
    public string Category { get; set; }
}
