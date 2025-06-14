using LessonOnionArc.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Application.Abstraction.Repositories;
public interface IReadRepository<T> : IRepositry<T> where T : BaseEntity
{
}
