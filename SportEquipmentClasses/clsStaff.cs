using System;
using System.Collections.Generic;

namespace SportEquipmentClasses
{
    public class clsStaff
    {
        private Int32 id;
        private string fullname;
        private string position;
        private string department;
        private string password;
        private DateTime hireDate;
        private bool isActive;

        public Int32 Id { get { return id; } set { id = value; } }
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

        public bool Find(int staffId) {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@staff_id", staffId);
            db.Execute("sproc_tblStaff_FilterByStaffID");

            if (db.Count == 1)
            {
                id = Convert.ToInt32(db.DataTable.Rows[0]["staff_id"]);
                password = Convert.ToString(db.DataTable.Rows[0]["password"]);
                fullname = Convert.ToString(db.DataTable.Rows[0]["full_name"]);
                hireDate = Convert.ToDateTime(db.DataTable.Rows[0]["hire_date"]);
                position = Convert.ToString(db.DataTable.Rows[0]["position"]);
                department = Convert.ToString(db.DataTable.Rows[0]["department"]);
                isActive = Convert.ToBoolean(db.DataTable.Rows[0]["is_active"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        // staff ID must be a positive integer
        // Only 0-9 characters are allowed
        public string ValidId(string staffId)
        {
            string errorMsg = "";
            int value;
            try
            {
                value = Convert.ToInt32(staffId);
            }
            catch (System.FormatException)
            {
                errorMsg = "ID must be a positive integer!";
                return errorMsg;
            }

            if (value < 0 || value > 256)
            {
                errorMsg = "ID must be a positive integer not greater than 256!";
            }

            return errorMsg;
        }

        // Full name must be non-empty string
        // must contain a-z A-Z characters only
        public string ValidFullname(string staffFullname)
        {
            if (staffFullname.Length == 0)
                return "This field is required!";

            foreach (char c in staffFullname)
            {
                if (!Char.IsLetter(c))
                    return "Full name must contain only letters!";
            }

            return "";
        }

    }
}