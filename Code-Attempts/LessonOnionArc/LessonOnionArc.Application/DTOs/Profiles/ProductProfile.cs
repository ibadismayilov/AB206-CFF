using AutoMapper;
using LessonOnionArc.Application.DTOs.Product;
using LessonOnionArc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application.DTOs.Profiles;
public class ProductProfile : Profile
{
    public ProductProfile()
    {
        CreateMap<ProductEntity, ProductGetDTO>();
    }
}
