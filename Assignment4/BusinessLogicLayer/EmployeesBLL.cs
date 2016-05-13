using DataAccessLayer;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class EmployeesBLL
    {
        EmployeesDAL emp = new EmployeesDAL();
        List<EmployeeModel> empList;

        public List<EmployeeModel> CreateEmployee(EmployeeModel empModel)
        {
           return emp.CreateEmployee(empModel);
        }

        public void UpdateEmployee(EmployeeModel empModel)
        {
            emp.UpdateEmployee(empModel);
        }

        public EmployeeModel GetEmployee(string Email)
        {
            EmployeeModel empModel = emp.GetEmployee(Email);
            return empModel;
        }

        public List<EmployeeModel> GetEmployees()
        {
            empList=emp.GetEmployees();
            return empList;
        }
    }
}
