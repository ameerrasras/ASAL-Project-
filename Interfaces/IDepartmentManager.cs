using Business.Models;

namespace Business.Interfaces
{
    public interface IDepartmentManager
    {
        Task<List<DepartmentModel>> GetAllDepartments();
        Task<DepartmentModel> GetDepartmentById(int departmentId);

        Task<int> CreateDepartment(DepartmentModel departmentModel);
        Task<bool> UpdateDepartment(int departmentId, DepartmentModel departmentModel);
        Task<bool> DeleteDepartment(int departmentId);
    }
}




