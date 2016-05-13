using BusinessLogicLayer;
using DataAccessLayer;
using Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Assignment4.Controllers
{
    public class EmployeeController : Controller
    {
        private static EmployeesBLL _employees = new EmployeesBLL();

        public ActionResult Index()
        {
            return View(_employees.GetEmployees());
        }
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(EmployeeModel empModel)
        {
            List<EmployeeModel> emplist= _employees.CreateEmployee(empModel);

            return View("../Employee/Index", emplist);
        }

    }
}