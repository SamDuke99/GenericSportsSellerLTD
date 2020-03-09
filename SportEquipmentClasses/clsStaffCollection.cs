using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEquipmentClasses
{
    public class clsStaffCollection
    {
        private List<clsStaff> staffList = new List<clsStaff>();

        public List<clsStaff> StaffList { get { return staffList; } }

        public clsStaffCollection() { }
        public clsStaffCollection(List<clsStaff> staffList)
        {
            this.staffList = staffList;
        }

        public void Add(clsStaff staffMember)
        {
            staffList.Add(staffMember);
        }

        // Searches for a staff member with specified ID.
        // Returns reference to found object if succeed.
        // Returns null otherwise.
        public clsStaff Find(int staffId)
        {
            foreach (clsStaff var in staffList)
            {
                if (var.Id == staffId)
                    return var;
            }

            return null;
        }

        // Deletes a staff member with specified ID.
        public void Delete(int staffId)
        {
            for (int i = 0; i < staffList.Count; i++)
            {
                if (staffList[i].Id == staffId)
                {
                    StaffList.RemoveAt(i);
                    break;
                }
            }
        }

        // Filters staff members using filter passed by filterMethod.
        // Returns filtered clsStaffCollection instance.
        public clsStaffCollection Filter(Func<clsStaff, bool> filterMethod)
        {
            clsStaffCollection filteredStaff = new clsStaffCollection();

            foreach (clsStaff var in staffList)
            {
                if (filterMethod(var))
                    filteredStaff.Add(var);
            }

            return filteredStaff;
        }

        public static bool filterAdmin(clsStaff staffMember)
        {
            return staffMember.Position == "admin";
        }

        public static bool filterManager(clsStaff staffMember)
        {
            return staffMember.Position == "manager";
        }

        public static bool filterSeller(clsStaff staffMember)
        {
            return staffMember.Position == "seller";
        }
    }
}
