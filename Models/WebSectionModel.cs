using System;
namespace Business.Models
{

    public class WebSectionModel : TrackingDataModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

