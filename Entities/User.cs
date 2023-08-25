namespace Infrastructure.Entities;


    public class User : TrackingData
{
        public int Id { get; set; } // Primary Key
        public string UserId { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

   

    

  

   

    