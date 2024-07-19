
using Day17_Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Approach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDBEntities testempdb = new EmployeeDBEntities();
            List<Employee> employees = testempdb.Employees.ToList();
            List<Department> departments = testempdb.Departments.ToList();

            Employee emp = new Employee
            {
                EmployeeId = 1,
                EmployeeName = "Yashu",
                Age = 23,
                Gender = "female",
                City = "kadapa",
                Address = "Ap"
            };

            Employee emp1 = new Employee
            {
                EmployeeId = 2,
                EmployeeName = "Lahari",
                Age = 17,
                Gender = "female",
                City = "viazg",
                Address = "Ap"
            };

            Employee emp3 = new Employee
            {
                EmployeeId = 3,
                EmployeeName = "Sravya",
                Age = 29,
                Gender = "female",
                City = "",
                Address = "hyd"
            };

            testempdb.Employees.Add(emp);
            testempdb.Employees.Add(emp1);
            testempdb.Employees.Add(emp3);

            Department dept = new Department
            {
                DeptName = "IT",
                DeptId = 1,
                DeptCreation = DateTime.Today
            };

            Department dept1 = new Department
            {
                DeptName = "HR",
                DeptId = 2,
                DeptCreation = DateTime.Today
            };

            Department dept2 = new Department
            {
                DeptName = "Development",
                DeptId = 3,
                DeptCreation = DateTime.Today
            };

            testempdb.Departments.Add(dept);
            testempdb.Departments.Add(dept1);
            testempdb.Departments.Add(dept2);

            testempdb.SaveChanges();
        }
    }
}


