using EmployeeManagementDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementDemo.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);

        List<Employee> GetEmployees();

        Employee Add(Employee employee);

        List<Department> GetDepartments();


    }
}
