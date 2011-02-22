using System;
using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Patient : Entity
    {
        [Mandatory]
        public string Name { get; set; }
        public string Hometown { get; set; }
        [StringLength(2)]
        public string State { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime Anniversary { get; set; }
    }

    public class MandatoryAttribute : Attribute {}
}