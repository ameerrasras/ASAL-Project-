using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

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
                optionsBuilder.UseMySql("Server=localhost;port=3306;Database=ASALProject;user=root;password=; persist security Info=true", ServerVersion.AutoDetect("Server=localhost;port=3306;Database=ASALProject;user=root;password=; persist security Info=true"));
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
         new Department
         {
             Id = 1,
             Name = "Engineering",
             Description = "Handles all engineering stuff",
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
