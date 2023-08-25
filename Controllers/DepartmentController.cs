using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentManager _departmentManager;

        public DepartmentsController(IDepartmentManager departmentManager)
        {
            _departmentManager = departmentManager ?? throw new ArgumentNullException(nameof(departmentManager));
        }

        // GET: api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentModel>>> GetDepartments()
        {
            var departments = await _departmentManager.GetAllDepartments();
            return Ok(departments);
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DepartmentModel>> GetDepartment(int id)
        {
            var department = await _departmentManager.GetDepartmentById(id);

            if (department == null)
            {
                return NotFound();
            }

            return Ok(department);
        }

        // POST: api/Departments
        [HttpPost]
        public async Task<ActionResult<DepartmentModel>> CreateDepartment(DepartmentModel departmentModel)
        {
            var id = await _departmentManager.CreateDepartment(departmentModel);
            return CreatedAtAction(nameof(GetDepartment), new { id }, departmentModel);
        }

        // PUT: api/Departments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, DepartmentModel departmentModel)
        {
            var updated = await _departmentManager.UpdateDepartment(id, departmentModel);
            if (!updated)
            {
                return NotFound();
            }
            return NoContent();
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var deleted = await _departmentManager.DeleteDepartment(id);
            if (!deleted)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
