using Business.Interfaces;
using Business.Models;
using Infrastructure.Context;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Mapping; 

public class DepartmentManager : IDepartmentManager
{
    private readonly DepartmentContext _context;

    public DepartmentManager(DepartmentContext context)
    {
        _context = context;
    }

    public async Task<List<Department>> GetAllDepartments()
    {
        return await _context.Departments
                             .Where(d => !d.IsDeleted)
                             .Select(d =>d) 
                             .ToListAsync();
    }

    public async Task<Department> GetDepartmentById(int departmentId)
    {
        var department = await _context.Departments.FindAsync(departmentId);
        if (department == null || department.IsDeleted)
        {
            return null;
        }

        return (department); 
    }

    public async Task<int> CreateDepartment(DepartmentModel departmentModel)
    {
        var department = DepartmentMapping.MapToEntity(departmentModel);
        _context.Departments.Add(department);
        await _context.SaveChangesAsync();
        return department.Id;
    }

    public async Task<bool> UpdateDepartment(int departmentId, DepartmentModel departmentModel)
    {
        var department = await _context.Departments.FindAsync(departmentId);
        if (department == null || department.IsDeleted)
        {
            return false;
        }

        department = DepartmentMapping.MapToEntity(departmentModel); 
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteDepartment(int departmentId)
    {
        var department = await _context.Departments.FindAsync(departmentId);
        if (department == null)
        {
            return false;
        }

        department.IsDeleted = true; // Soft delete
        await _context.SaveChangesAsync();
        return true;
    }
}
