using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonRepository.DAL.Entities;

public class Product : BaseEntity
{
    public string Image { get; set; }
    public string Title { get; set; }
    public string Desc { get; set; }
}
