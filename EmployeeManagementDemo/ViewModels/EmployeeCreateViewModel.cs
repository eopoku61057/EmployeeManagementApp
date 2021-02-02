using EmployeeManagementDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementDemo.ViewModels
{
    public class EmployeeCreateViewModel
    {
        public Employee Employee { get; set; }

        public List<Department> Departments { get; set; }
    }
}
