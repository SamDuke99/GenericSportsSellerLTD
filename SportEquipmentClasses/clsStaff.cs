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
            this.id = id;
            this.fullname = fullname;
            this.position = position;
            this.department = department;
            this.password = password;
            this.hireDate = hireDate;
            this.isActive = isActive;
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
                return "Full name must be at least 1 character long!";

            if (staffFullname.Length > 32)
                return "Full name cannot be longer than 32 characters!";

            foreach (char c in staffFullname)
            {
                if ((!Char.IsLetter(c) && c != ' ') || c >= sbyte.MaxValue)
                    return "Full name must contain only ascii letters!";
            }

            return "";
        }

        // length 8 <= _ <= 32
        // allowed charsL a-z A-Z 0-9 # @ ? ! % $ & *
        // ascii only
        public string ValidPassword(string staffPassword)
        {
            string errorMsg = "";

            if (staffPassword.Length < 8)
                errorMsg = "Password must be at least 8 characters long!";
            else if (staffPassword.Length > 32)
                errorMsg = "Password must be no longer than 32 characters!";
            else
            {
                foreach (char c in staffPassword)
                {
                    if (c >= sbyte.MaxValue)
                    {
                        errorMsg = "Password must contain only ascii characters!";
                        break;
                    }
                    
                    if (!Char.IsLetter(c))
                    {
                        if ("#@?!%$&*".IndexOf(c) == -1 && Char.IsDigit(c) == false)
                            errorMsg = "a-z A-Z 0-9 # @ ? ! % $ & * characters are allowd!";
                    }
                }
            }
            

            return errorMsg;
        }

        public string ValidHireDate(string staffHireDate)
        {
            string errorMsg = "";

            try
            {
                DateTime dateTemp = Convert.ToDateTime(staffHireDate);
            } catch
            {
                errorMsg = "Date should be in DD/MM/YYYY format!";
            }

            return errorMsg;
        }

        public string ValidPosition(string staffPosition)
        {
            if (staffPosition != "admin" && staffPosition != "seller" && staffPosition != "manager")
                return "Allowed positions: admin, seller, manager!";
            else
                return "";
        }

        public string ValidDepartment(string staffDepartment)
        {
            if (staffDepartment != "football" && staffDepartment != "fitness" && staffDepartment != "martial")
                return "Allowed departments: football, fitness, martial!";
            else
                return "";
        }

    }
}