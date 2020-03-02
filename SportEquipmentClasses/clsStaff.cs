using System;
using System.Collections.Generic;

namespace SportEquipmentClasses
{
    public class clsStaff
    {
        // Args passed to setters must be validated
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Password { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsActive { get; set; }
    }
}