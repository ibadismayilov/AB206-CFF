using LessonOnionArc.Domain.Entities.Base;

namespace LessonOnionArc.Application.Abstraction.Repositories;

public interface IWriteRepository<T> : IRepositry<T> where T : BaseEntity
{
}