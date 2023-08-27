using System;
namespace Business.Models
{
    public class UserDetailsModel : TrackingDataModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
    }
}

