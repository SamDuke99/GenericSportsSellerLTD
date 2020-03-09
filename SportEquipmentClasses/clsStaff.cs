using System;
using System.Collections.Generic;

namespace SportEquipmentClasses
{
    public class clsStaff
    {
        private int id;
        private string fullname;
        private string position;
        private string department;
        private string password;
        private DateTime hireDate;
        private bool isActive;

        public int Id { get { return id; } set { id = value; } }
        public string Fullname { get { return fullname; } set { fullname = value; } }
        public string Position { get { return position; } set { position = value; } }
        public string Department { get { return department; } set { department = value; } }
        public string Password { get { return password;  } set { password = value; } }
        public DateTime HireDate { get { return hireDate; } set { hireDate = value; } }
        public bool IsActive { get { return isActive; } set { isActive = value; } }

        public clsStaff() {}
        public clsStaff(int id, string fullname, string position, string department, string password, DateTime hireDate, bool isActive) {
            Id = id;
            Fullname = fullname;
            Position = position;
            Department = department;
            Password = password;
            HireDate = hireDate;
            IsActive = isActive;
        }

        ~clsStaff() {}

    }
}