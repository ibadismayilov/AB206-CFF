using LessonRepository.DAL.Contexts;
using LessonRepository.DAL.Entities;
using LessonRepository.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonRepository.DAL.Repositories.Concretes;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _appDbContext;

    public Repository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public IQueryable<T> GetAll()
    {
        IQueryable<T> products = _appDbContext.Set<T>().AsQueryable();
        return products;
    }
}
