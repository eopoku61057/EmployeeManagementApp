using EmployeeManagementDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementDemo.Repository
{
    public class MockRepository : IEmployeeRepository
    {
        private List<Employee> _employees;


        public MockRepository()
        {
            _employees = new List<Employee>
            {
                new Employee{Id=1,Name="PRP", Email="prp@test.com", Department=new Department{DepartmentId=1,DepartmentName="HR"} },
                new Employee{Id=2,Name="Mary", Email="mary@test.com", Department=new Department{DepartmentId=2,DepartmentName="IT"} }
            };


        }

        public Employee Add(Employee employee)
        {

            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
            return employee;
        }

        public List<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department{DepartmentId=1,DepartmentName="HR"},
                new Department{DepartmentId=2,DepartmentName="IT"},
                new Department{DepartmentId=3,DepartmentName="Payroll"}
            };
        }

        public Employee GetEmployeeById(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }
    }
}
