using System;
namespace Business.Models
{
    public class UserModel : TrackingDataModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}

