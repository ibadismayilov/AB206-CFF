﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVilla.DAL.Models;

public class Car
{
    public int Id { get; set; }
    public string ImgPath { get; set; }
    public string Model { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
}
