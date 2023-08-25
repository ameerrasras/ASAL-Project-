using System;
using Infrastructure.Entities;
using Business.Models;
using Business.Views;

namespace Business.Mapping
{
    public static class DepartmentMapping
    {
        public static DepartmentView MapToView(DepartmentModel departmentModel)
        {
            if (departmentModel == null)
                return null;

            return new DepartmentView
            {
                Id = departmentModel.Id, 
                Name = departmentModel.Name,
                Description = departmentModel.Description
            };
        }

       

        public static Department MapToEntity(DepartmentModel departmentModel)
        {
            if (departmentModel == null)
                return null;

            return new Department
            {
                Id = departmentModel.Id, 
                Name = departmentModel.Name,
                Description = departmentModel.Description
            };
        }

        public static DepartmentModel MapToModel(Department departmentEntity)
        {
            if (departmentEntity == null)
                return null;

            return new DepartmentModel
            {
                Id = departmentEntity.Id,  
                Name = departmentEntity.Name,
                Description = departmentEntity.Description
            };
        }
    }
}
