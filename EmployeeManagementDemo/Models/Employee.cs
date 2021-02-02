using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementDemo.Models
{
    public partial class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name cannot be empty")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email cannot be empty")]
        public string Email { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
