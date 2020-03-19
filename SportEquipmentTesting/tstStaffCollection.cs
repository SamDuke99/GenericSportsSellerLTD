using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;
using System.Collections.Generic;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            Assert.IsNotNull(staffList);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            List<clsStaff> testList = new List<clsStaff>();
            clsStaff staffMember = new clsStaff();
            staffMember.Id = 0;
            staffMember.Fullname = "Paul Morphy";
            staffMember.HireDate = DateTime.Now.Date;
            staffMember.Password = "chicken";
            staffMember.IsActive = true;
            staffMember.Position = "admin";
            staffMember.Department = "football";
            testList.Add(staffMember);
            staffList.StaffList = testList;
            Assert.AreEqual(staffList.StaffList, testList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            Int32 someCount = 0;
            Assert.AreNotEqual(someCount, staffList.Count);
        }
        


        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            List<clsStaff> testList = new List<clsStaff>();
            clsStaff staffMember = new clsStaff();
            staffMember.Fullname = "Paul Morphy";
            staffMember.HireDate = DateTime.Now.Date;
            staffMember.Password = "chicken";
            staffMember.IsActive = true;
            staffMember.Position = "admin";
            staffMember.Department = "football";
            testList.Add(staffMember);
            staffList.StaffList = testList;
            Assert.AreEqual(staffList.Count, testList.Count);
        }

        [TestMethod]
        public void ReportByPositionDataFound()
        {
            clsStaffCollection filteredCollection = new clsStaffCollection();
            Boolean ok = true;
            filteredCollection.ReportByPosition("admin");

            if (filteredCollection.Count >= 2)
            {
                if (filteredCollection.StaffList[0].Id != 1 || filteredCollection.StaffList[1].Id != 10)
                    ok = false;
            }
            else
                ok = false;

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            clsStaff staffMember = new clsStaff();
            Int32 primaryKey = 0;
            staffMember.Fullname = "Mikhail Tal";
            staffMember.HireDate = DateTime.Now;
            staffMember.Position = "admin";
            staffMember.Department = "football";
            staffMember.Password = "chicken12";
            staffMember.IsActive = true;

            staffList.ThisStaffMember = staffMember;
            primaryKey = staffList.Add();
            staffMember.Id = primaryKey;
            staffList.ThisStaffMember.Find(primaryKey);
            Assert.AreEqual(staffList.ThisStaffMember, staffMember);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            clsStaff staffMember = new clsStaff();
            Int32 primaryKey = 0;
            staffMember.Fullname = "Mikhail Tal";
            staffMember.HireDate = DateTime.Now.Date;
            staffMember.Position = "admin";
            staffMember.Department = "football";
            staffMember.Password = "chicken12";
            staffMember.IsActive = true;
            staffList.ThisStaffMember = staffMember;
            primaryKey = staffList.Add();
            staffMember.Id = primaryKey;
            staffList.Delete();
            Boolean found = staffList.ThisStaffMember.Find(primaryKey);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection staffList = new clsStaffCollection();
            clsStaff staffMember = new clsStaff();
            Int32 primaryKey;
            staffMember.Fullname = "Mikhail Tal";
            staffMember.HireDate = DateTime.Now.Date;
            staffMember.Position = "admin";
            staffMember.Department = "football";
            staffMember.Password = "chicken12";
            staffMember.IsActive = true;
            staffList.ThisStaffMember = staffMember;
            primaryKey = staffList.Add();
            staffMember.Id = primaryKey;
            staffMember.Fullname = "Alexander Alekhine";
            staffMember.HireDate = DateTime.Now.Date;
            staffMember.Position = "manager";
            staffMember.Department = "fitness";
            staffMember.Password = "turkey123";
            staffMember.IsActive = false;
            staffList.ThisStaffMember = staffMember;
            staffList.Update();
            staffList.ThisStaffMember.Find(primaryKey);
            Assert.AreEqual(staffList.ThisStaffMember, staffMember);
        }

    }
}
