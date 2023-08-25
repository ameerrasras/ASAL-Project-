using System;
namespace Infrastructure.Entities;

    public class UserDetails : TrackingData
{
        public int Id { get; set; } // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }

    }
