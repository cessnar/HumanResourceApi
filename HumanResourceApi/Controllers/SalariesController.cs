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
    public class SalariesController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public SalariesController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("GetSalaries")]
        public async Task<ActionResult<IEnumerable<Salary>>> GetSalaries()
        {
            return await _context.Salaries.ToListAsync();
        }

        [HttpGet("GetSalary")]
        public async Task<ActionResult<Salary>> GetSalary(int id)
        {
            var salary = await _context.Salaries.FindAsync(id);

            if (salary == null)
            {
                return NotFound();
            }

            return salary;
        }

        [HttpGet("GetSalaryByEmployeeId")]
        public IActionResult GetSalaryByEmployeeId(int employeeId)
        {
            var salaries = _context.Salaries.Where(s => s.EmployeeId.Equals(employeeId)).ToArray();

            if (salaries == null)
            {
                return NotFound();
            }

            return new JsonResult(salaries);
        }

        [HttpPost("AddNewSalary")]
        public IActionResult AddNewSalary(Salary salary)
        {
            _context.Salaries.Add(salary);
            _context.SaveChanges();

            return new JsonResult("Success");

        }
    }
}
