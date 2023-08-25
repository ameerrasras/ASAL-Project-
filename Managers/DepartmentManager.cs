using Business.Interfaces;
using Business.Models;
using Infrastructure.Context;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Mapping; // Add this if DepartmentMapping is in a different namespace

public class DepartmentManager : IDepartmentManager
{
    private readonly DepartmentContext _context;

    public DepartmentManager(DepartmentContext context)
    {
        _context = context;
    }

    public async Task<List<DepartmentModel>> GetAllDepartments()
    {
        return await _context.Departments
                             .Where(d => !d.IsDeleted)
                             .Select(d => DepartmentMapping.MapToModel(d)) // Assuming you have MapToModel in DepartmentMapping
                             .ToListAsync();
    }

    public async Task<DepartmentModel> GetDepartmentById(int departmentId)
    {
        var department = await _context.Departments.FindAsync(departmentId);
        if (department == null || department.IsDeleted)
        {
            return null;
        }

        return DepartmentMapping.MapToModel(department); // Map to DepartmentModel and return
    }

    public async Task<int> CreateDepartment(DepartmentModel departmentModel)
    {
        var department = DepartmentMapping.MapToEntity(departmentModel); // map properties from departmentModel
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

        department = DepartmentMapping.MapToEntity(departmentModel); // Update properties from departmentModel
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
