using Azure;
using DAL.Contexts;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Contracts;

public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;

    public ReadRepository(AppDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public IQueryable<T> GetAll(bool isTracking = false, int page = 1, int take = 10)
    {
        IQueryable<T> query = Table.AsQueryable();

        if (!isTracking)
        {
            query = query.AsNoTracking();
        }

        return query.Skip((page - 1) * take).Take(take);
    }

    public T? GetById(int id, bool isTracking = false)
    {
        IQueryable<T> query = Table.AsQueryable();

        if (!isTracking)
        {
            query = query.AsNoTracking();
        }

        return query.FirstOrDefault(e=>e.Id == id);
    }
}
