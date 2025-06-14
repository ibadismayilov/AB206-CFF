using LessonCrud.Contexts;
using LessonCrud.Models;

namespace LessonCrud.Services;

public class EmployeeService
{
    private readonly AppDbContext _appDbContext;

    public EmployeeService()
    {
        _appDbContext = new AppDbContext();
    }

    public List<EmployeeModel> GetAllEmp()
    {
        return _appDbContext.EmployeeModels.ToList();
    }

    public void CreateEmp(EmployeeModel employee)
    {
        _appDbContext.EmployeeModels.Add(employee);
        _appDbContext.SaveChanges();
    }
}
