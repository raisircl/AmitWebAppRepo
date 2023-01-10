using AmitWebAppMVC.Models;
using AmitWebAppMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AmitWebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository repository;
        
        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository; // DI
            
        }
        public IActionResult Index()
        {
            List<Employee> model= repository.GetAllEmployees();
            ViewData["Title"] = "All Employees";
            ViewData["msg"] = "Welcome to View Data";
            return View(model);
        }
        public IActionResult Details(int id=1001)
        {
            EmployeeViewModel model = new EmployeeViewModel()
            {
                Employee= repository.GetEmployee(id),
                PageData = new PageData{ PageTitle = "Employee Detail", PageDescription = "Details of Employee" }
        };
            //ViewBag.EmpDetail = repository.GetEmployee(id);
            return View(model);
        }
        public JsonResult Data(int id=1001)
        {
            return Json(repository.GetEmployee(id));
        }
       
    }
}
