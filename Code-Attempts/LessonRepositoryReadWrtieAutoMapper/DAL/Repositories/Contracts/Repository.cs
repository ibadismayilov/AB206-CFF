using DAL.Contexts;
using DAL.Entities;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories.Contracts;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly AppDbContext _context;
    public DbSet<T> Table => _context.Set<T>();

    public Repository(AppDbContext context)
    {
        _context = context;
    }
}
