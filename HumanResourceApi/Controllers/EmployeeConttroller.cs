using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HumanResourceApi.Db.Context;
using HumanResourceApi.Db.Model;
using Microsoft.AspNetCore.Authorization;

namespace HumanResourceApi.Controllers
{

    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DatabaseContext _Context;


        public EmployeeController(DatabaseContext context)
        {
            _Context = context;


        }

        // GET: api/Employee
        [HttpGet("GetEmployees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
        {
            return await _Context.Employees.ToListAsync();
        }

        // GET: api/Employee/5
        [HttpGet("GetEmployee/{Email}")]
        public async Task<ActionResult<Employee>> GetEmployee(string Email)
        {
            var employees = _Context.Employees.FirstOrDefault(
               emp => emp.Email == Email);

            if (employees == null)
            {
                return NotFound();
            }

            return employees;
        }


        [HttpPost("EditEmployee")]
        public IActionResult EditEmployee(Employee newEmployee)
        {
            var oldEmployee = _Context.Employees.FirstOrDefault(x => x.EmployeeId == newEmployee.EmployeeId);

            if (oldEmployee == null)
            {
                return NotFound();


            }
            oldEmployee.Email = newEmployee.Email;
            oldEmployee.UserName = newEmployee.UserName;
            oldEmployee.FirstName = newEmployee.FirstName;
            oldEmployee.LastName = newEmployee.LastName;
            oldEmployee.Date = newEmployee.Date;
            oldEmployee.NickName = newEmployee.NickName;
            oldEmployee.Roles = newEmployee.Roles;
            oldEmployee.Contract = newEmployee.Contract;
            oldEmployee.EmployeeId = newEmployee.EmployeeId;


            _Context.SaveChanges();
            return new OkResult();

        }


        // PUT: api/Employee/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost("AddNewEmployee")]
        public IActionResult AddNewEmployee(Employee employee)
        {
            _Context.Employees.Add(employee);
            _Context.SaveChanges();
            return new JsonResult("success");
        }

        [HttpPost("DeleteEmployee/{Email}")]
        public ActionResult<Employee> DeleteEmployee(string Email)
        {
            var employee = _Context.Employees.FirstOrDefault(
                emp => emp.Email == Email);

            if (employee == null)
            {
                return NotFound();
            }

            _Context.Employees.Remove(employee);
            _Context.SaveChanges();

            return employee;
        }

    }
}
