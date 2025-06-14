using LessonRepository.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonRepository.DAL.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
    }
}
