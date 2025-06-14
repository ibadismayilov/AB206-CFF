using LessonOnionArc.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application.Abstraction.Repositories;
public interface IRepositry<T> where T : BaseEntity
{
    DbSet<T> Table { get; }
}
