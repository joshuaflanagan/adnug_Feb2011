using System;

namespace MyMvcApp.Models
{
    public class Appointment : Entity
    {
        public string Patient { get; set; }
        public DateTime CoverageDate { get; set; }
        public string Physician { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}