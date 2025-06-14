using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cybor2.BL.ViewModels;

public class UpdateVM
{
    [Required(ErrorMessage = "Please select a image")]
    public IFormFile ImgFile { get; set; }

    [Required(ErrorMessage = "Please fill input")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Please fill input")]
    public string Desc { get; set; }
}
