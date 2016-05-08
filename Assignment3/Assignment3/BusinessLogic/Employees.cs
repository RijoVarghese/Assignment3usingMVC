using Assignment3usingMVC.Models;
using System;
using System.Collections.Generic;

namespace Assignment3usingMVC.BusinessLogic
{
    public class Employees
    {
        public Employees()
        {
            EmployeeList.Add(new EmployeeModel
            {
                FirstName = "Rijo",
                LastName = "Varghese",
                Address = "Overland Park, KS",
                Email = "rijo.varghese9@gmail.com",
                DOB = Convert.ToDateTime("09/09/1988"),
                Salary = 80000

            });
            EmployeeList.Add(new EmployeeModel
            {
                FirstName = "AAA",
                LastName = "ZZZ",
                Address = "Harrisburg, PA",
                Email = "email@test.com",
                DOB = Convert.ToDateTime("06/12/1988"),
                Salary = 40000

            });
            EmployeeList.Add(new EmployeeModel
            {
                FirstName = "SSS",
                LastName = "QQQ",
                Address = "Harrisburg, PA",
                Email = "example@test.com",
                DOB = Convert.ToDateTime("09/10/1995"),
                Salary = 45000

            });
        }

        public List<EmployeeModel> EmployeeList = new List<EmployeeModel>();

        public void CreateEmployee(EmployeeModel empModel)
        {
            EmployeeList.Add(empModel);
        }

        public void UpdateEmployee(EmployeeModel empModel)
        {
            foreach (EmployeeModel empList in EmployeeList)
            {
                if (empList.Email == empModel.Email)
                {
                    EmployeeList.Remove(empList);
                    EmployeeList.Add(empModel);
                    break;
                }
            }
        }
        public EmployeeModel GetEmployee(string Email)
        {
            EmployeeModel empModel = null;

            foreach (EmployeeModel emp in EmployeeList)
                if (emp.Email == Email)
                    empModel = emp;

            return empModel;
        }
    }
}
