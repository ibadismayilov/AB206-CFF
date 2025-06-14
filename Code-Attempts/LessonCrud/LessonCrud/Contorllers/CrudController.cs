using LessonCrud.Models;
using LessonCrud.Services;
using Microsoft.AspNetCore.Mvc;

namespace LessonCrud.Contorllers
{
    public class CrudController : Controller
    {

        private readonly EmployeeService _employeeService;

        public CrudController()
        {
            _employeeService = new EmployeeService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeModel employeeModel)
        {
            _employeeService.CreateEmp(employeeModel);
            return View();
        }
    }
}
