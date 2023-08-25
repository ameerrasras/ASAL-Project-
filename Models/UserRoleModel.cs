using System;
namespace Business.Models
{
    public class UserRoleModel : TrackingDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}

