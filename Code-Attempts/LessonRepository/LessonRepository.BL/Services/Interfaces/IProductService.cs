﻿using LessonRepository.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonRepository.BL.Services.Interfaces;

public interface IProductService
{
    List<Product> GetAllProducts();
}
