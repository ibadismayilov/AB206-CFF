using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.DAL.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string ImgPath { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
}
