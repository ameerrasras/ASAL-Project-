using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infrastructure.Context
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext() : base() { }

        public DepartmentContext(DbContextOptions<DepartmentContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(local);Database=ASALProject;User Id=sa;Password=;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
              
                new Department
                {
                    Id = 2,
                    Name = "HR",
                    Description = "Human Resources",
                    CreatedBy = "System",
                    CreatedOn = DateTime.Now,
                    ModifiedBy = "System",
                    ModifiedOn = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}
