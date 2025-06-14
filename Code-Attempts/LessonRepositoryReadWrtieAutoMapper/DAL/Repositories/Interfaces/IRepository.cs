﻿using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}
