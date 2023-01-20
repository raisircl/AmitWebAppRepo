using AmitWebAppMVC.Models;
using AmitWebAppMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AmitWebAppMVC.Controllers
{
    [Route("[controller]/[action]/{id?}")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository repository;
        
        public EmployeeController(IEmployeeRepository repository)
        {
            this.repository = repository; // DI
            
        }
        [Route("/")]
        [Route("/[controller]")]
        [Route("/[controller]/[action]")]
        public IActionResult Index()
        {
            List<Employee> model= repository.GetAllEmployees();
            ViewData["Title"] = "All Employees";
            ViewData["msg"] = "Welcome to View Data";
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
               Employee x= repository.Add(emp);
                return RedirectToAction("Details", new { id = x.Id }); 
            }
            return View();
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
       
        [Route("amit")]
        public JsonResult Data(int id=1001)
        {
            return Json(repository.GetEmployee(id));
        }
       
    }
}
