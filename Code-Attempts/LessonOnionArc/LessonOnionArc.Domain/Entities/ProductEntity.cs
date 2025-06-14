using LessonOnionArc.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Domain.Entities;
public class ProductEntity : BaseEntity
{
    public string Title { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }
}
