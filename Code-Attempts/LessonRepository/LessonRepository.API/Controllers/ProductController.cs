using LessonRepository.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LessonRepository.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> getAllProduct = [];

            Product product = new Product
            { 
                Id = 1,
                Image="Image.png",
                Title="Ibad",
                Desc="Ismayılov"
            };

            return Ok(getAllProduct);

        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id) 
        {
            Product product = new Product
            {
                Id = 1,
                Image = "Image.png",
                Title = "Ibad",
                Desc = "Ismayılov"
            };

            return Ok(product);
        }
    }
}
