﻿using System;
namespace Business.Models
{
    public class EmployeeDetailsModel:TrackingDataModel
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}

