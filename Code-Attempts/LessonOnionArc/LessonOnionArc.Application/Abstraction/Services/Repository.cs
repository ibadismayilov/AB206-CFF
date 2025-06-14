using LessonOnionArc.Application.Abstraction.Repositories;
using LessonOnionArc.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application.Abstraction.Services;
public class Repository<T> : IRepositry<T> where T : BaseEntity
{
    public DbSet<T> Table => throw new NotImplementedException();
}
