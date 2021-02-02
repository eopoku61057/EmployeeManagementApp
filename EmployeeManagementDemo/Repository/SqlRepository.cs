using EmployeeManagementDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementDemo.Repository
{
    public class SqlRepository : IEmployeeRepository
    {
        private EmployeeDBContext _context;
        public SqlRepository(EmployeeDBContext context)
        {
            _context = context;
        }

        public Employee Add(Employee employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public List<Department> GetDepartments()
        {
            return _context.Department.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return _context.Employee.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employee.Include(x => x.Department).ToList();
        }
    }
}
