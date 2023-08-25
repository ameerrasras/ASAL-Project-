using System;
namespace Infrastructure.Entities;

    public class UserRole : TrackingData
{
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public string Description { get; set; }
    }


