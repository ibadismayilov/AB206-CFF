using LessonOnionArc.Application.Abstraction.Repositories;
using LessonOnionArc.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace LessonOnionArc.Persistence.Contexts.Repositories;

public class WriteRepositories<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly AppDbContext appDbContext;

    public WriteRepositories(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public DbSet<T> Table => appDbContext.Set<T>();
}
