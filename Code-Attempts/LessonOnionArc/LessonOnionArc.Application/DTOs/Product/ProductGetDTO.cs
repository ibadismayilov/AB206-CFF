using AutoMapper;
using LessonOnionArc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application.DTOs.Product;
public class ProductGetDTO
{
    public string Title { get; set; }
    public string Desc { get; set; }
    public double Price { get; set; }
}
