using System;
namespace Business.Models
{

    public class DepartmentModel : TrackingDataModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}

