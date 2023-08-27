using Business.Models;
using Infrastructure.Entities;


namespace Business.Interfaces
{
    public interface IDepartmentManager
    {
        Task<List<Department>> GetAllDepartments();
        Task<Department> GetDepartmentById(int departmentId);

        Task<int> CreateDepartment(DepartmentModel departmentModel);
        Task<bool> UpdateDepartment(int departmentId, DepartmentModel departmentModel);
        Task<bool> DeleteDepartment(int departmentId);
    }
}




