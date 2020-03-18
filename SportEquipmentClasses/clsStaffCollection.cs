using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEquipmentClasses
{
    public class clsStaffCollection
    {
        List<clsStaff> staffList = new List<clsStaff>();
        clsStaff thisStaffMember = new clsStaff();
        public List<clsStaff> StaffList { get { return staffList; } set { staffList = value; } }
        public clsStaff ThisStaffMember { get { return thisStaffMember; } set { thisStaffMember = value; } }

        public int Count { get { return staffList.Count; } set { } }

        public clsStaffCollection()
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            clsDataConnection db = new clsDataConnection();
            db.Execute("sproc_tblStaff_Select_All");
            recordCount = db.Count;

            while (index < recordCount)
            {
                clsStaff staffMember = new clsStaff();
                staffMember.Id = Convert.ToInt32(db.DataTable.Rows[index]["staff_id"]);
                staffMember.HireDate = Convert.ToDateTime(db.DataTable.Rows[index]["hire_date"]);
                staffMember.Position = Convert.ToString(db.DataTable.Rows[index]["position"]);
                staffMember.Department = Convert.ToString(db.DataTable.Rows[index]["department"]);
                staffMember.Fullname = Convert.ToString(db.DataTable.Rows[index]["full_name"]);
                staffMember.Password = Convert.ToString(db.DataTable.Rows[index]["password"]);
                staffMember.IsActive = Convert.ToBoolean(db.DataTable.Rows[index]["is_active"]);
                index++;
                staffList.Add(staffMember);
            }

  
        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@password", thisStaffMember.Password);
            db.AddParameter("@fullname", thisStaffMember.Fullname);
            db.AddParameter("@hiredate", thisStaffMember.HireDate);
            db.AddParameter("@position", thisStaffMember.Position);
            db.AddParameter("@department", thisStaffMember.Department);
            db.AddParameter("@active", thisStaffMember.IsActive);
            return db.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@id", thisStaffMember.Id);
            db.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@id", thisStaffMember.Id);
            db.AddParameter("@password", thisStaffMember.Password);
            db.AddParameter("@fullname", thisStaffMember.Fullname);
            db.AddParameter("@hiredate", thisStaffMember.HireDate);
            db.AddParameter("@position", thisStaffMember.Position);
            db.AddParameter("@department", thisStaffMember.Department);
            db.AddParameter("@active", thisStaffMember.IsActive);
            db.Execute("sproc_tblStaff_Update");
        }

    }
}
