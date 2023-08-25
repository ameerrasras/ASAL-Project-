using System;
namespace Infrastructure.Entities
{
    public class EmployeeDetails: TrackingData
    {
        public int Id { get; set; } // Primary Key
        public int DepartmentId { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

