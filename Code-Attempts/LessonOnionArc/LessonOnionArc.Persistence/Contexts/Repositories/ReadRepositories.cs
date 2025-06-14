using LessonOnionArc.Application.Abstraction.Repositories;
using LessonOnionArc.Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonOnionArc.Persistence.Contexts.Repositories;
public class ReadRepositories<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly AppDbContext appDbContext;

    public ReadRepositories(AppDbContext appDbContext)
    {
        this.appDbContext = appDbContext;
    }

    public DbSet<T> Table => appDbContext.Set<T>();
}

