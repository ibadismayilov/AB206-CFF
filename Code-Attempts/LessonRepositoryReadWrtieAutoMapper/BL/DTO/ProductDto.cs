using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO;

public class ProductDto
{
    public int Id { get; set; }
    public IFormFile ImgFile { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }
}
