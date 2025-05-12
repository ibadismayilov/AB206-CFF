using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Makan.DAL.Enums.ProductStatus;
using static Makan.DAL.Enums.ProductType;

namespace Makan.DAL.Model;

public class Product
{
    public int Id { get; set; }
    public PropertyStatus Status { get; set; }
    public string ImgUrl { get; set; }
    public PropertyType Type { get; set; }
    public double Price { get; set; }
    public string Title { get; set; }
    public string Location { get; set; }
    public int Size { get; set; }
    public int BedCount { get; set; } 
    public int BathCount { get; set; }
}
