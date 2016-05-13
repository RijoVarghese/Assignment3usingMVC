using Models;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class EmployeesDAL
    {
        public List<EmployeeModel> EmployeeList;

        public void Employees()
        {
            EmployeeList = new List<EmployeeModel>();
            EmployeeList.Add(new EmployeeModel
            {
                FirstName = "Rijo",
                LastName = "Varghese",
                Address = "Overland Park, KS",
                Email = "rijo@gmail.com",
                DOB = Convert.ToDateTime("01/21/1989"),
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

        public List<EmployeeModel> CreateEmployee(EmployeeModel empModel)
        {
            Employees();
            EmployeeList.Add(empModel);
            return EmployeeList;
        }

        public void UpdateEmployee(EmployeeModel empModel)
        {
            Employees();
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
            Employees();
            EmployeeModel empModel = null;

            foreach (EmployeeModel emp in EmployeeList)
                if (emp.Email == Email)
                    empModel = emp;

            return empModel;
        }

        public List<EmployeeModel> GetEmployees()
        {
            Employees();
            return EmployeeList;
        }
    }
}
