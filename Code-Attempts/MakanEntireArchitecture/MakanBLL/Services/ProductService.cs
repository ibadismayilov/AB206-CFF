using Makan.DAL.Contexts;
using Makan.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakanBLL.Services
{
    public class ProductService
    {
        AppDbContext _appDbContext { get; set; }

        public ProductService()
        {
            _appDbContext = new AppDbContext();
        }
        public List<Product> GetAllProdcut()
        {
             return _appDbContext.Products.ToList();
        }
    }
}
