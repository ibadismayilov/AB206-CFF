using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyborg.BL.ViewModels;

public class ProductVM
{
    [Required(ErrorMessage="Moye More")]
    public IFormFile ImgFile { get; set; }

    [Required(ErrorMessage = "Moye More")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Moye More")]
    public string Desc { get; set; }
}
