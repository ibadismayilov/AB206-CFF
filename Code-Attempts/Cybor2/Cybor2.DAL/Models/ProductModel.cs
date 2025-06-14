using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybor2.DAL.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string ImgPath { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
}
