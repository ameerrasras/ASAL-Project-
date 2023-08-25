using System;
namespace Infrastructure.Entities;

    public class WebSection : TrackingData
{
        public int Id { get; set; } // Primary Key
        public string Title { get; set; }
        public string Description { get; set; }
    }


