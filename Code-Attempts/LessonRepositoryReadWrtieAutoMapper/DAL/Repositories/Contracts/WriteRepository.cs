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

public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;

    public WriteRepository(AppDbContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public void Create(T entity)
    {
        Table.Add(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public void Update(T entity)
    {
        Table.Update(entity);
    }
    public void Save()
    {
        _context.SaveChanges();
    }
}
