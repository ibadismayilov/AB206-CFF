using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces;

public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
{
    void Create(T entity);
    void Delete(T entity);
    void Update(T entity);
    void Save();
}
