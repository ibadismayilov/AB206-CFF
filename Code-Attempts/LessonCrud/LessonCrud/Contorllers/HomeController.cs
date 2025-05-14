using LessonCrud.Services;
using Microsoft.AspNetCore.Mvc;

namespace LessonCrud.Contorllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public HomeController()
        {
            _employeeService = new EmployeeService();
        }

        public IActionResult Index()
        {
            var getAllEmp = _employeeService.GetAllEmp();
            return View(getAllEmp);
        }
    }
}
