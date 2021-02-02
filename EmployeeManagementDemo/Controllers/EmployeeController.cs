using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementDemo.Models;
using EmployeeManagementDemo.Repository;
using EmployeeManagementDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Create()
        {
            var viewModel = new EmployeeCreateViewModel
            {
                Departments = _employeeRepository.GetDepartments()
            };

            
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _employeeRepository.Add(viewModel.Employee);
                return RedirectToAction("List");
            }

            viewModel.Departments = _employeeRepository.GetDepartments();
            return View(viewModel);
                
        }

        public IActionResult List()
        {
            var employees = _employeeRepository.GetEmployees();
            return View(employees);
        }
    }
}
