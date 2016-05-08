using Assignment3usingMVC.BusinessLogic;
using Assignment3usingMVC.Models;
using System.Web.Mvc;

namespace Assignment3usingMVC.Controllers
{
    public class EmployeeController : Controller
    {
        
    
        private static Employees _employees = new Employees();

        public ActionResult Index()
        {
            return View(_employees.EmployeeList);
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel empModel)
        {
            _employees.CreateEmployee(empModel);
            return View();
        }

    }
}