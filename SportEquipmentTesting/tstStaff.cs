using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff person = new clsStaff();
            Assert.IsNotNull(person);
        }

        [TestMethod]
        public void IdPropertyOK()
        {
            clsStaff person = new clsStaff();
            person.Id = 49374;
            Assert.AreEqual(person.Id, 49374);
        }

        [TestMethod]
        public void FullNamePropertyOK() {
            clsStaff person = new clsStaff();
            person.Fullname = "Mikhail Tal";
            Assert.AreEqual(person.Fullname, "Mikhail Tal");
        }

        [TestMethod]
        public void PositionPropertyOK() {
            clsStaff person = new clsStaff();
            person.Position = "admin";
            Assert.AreEqual(person.Position, "admin");
        }

        [TestMethod]
        public void DepartmentPropertyOK() {
            clsStaff person = new clsStaff();
            person.Department = "martial arts";
            Assert.AreEqual(person.Department, "martial arts");
        }

        [TestMethod]
        public void PasswordPropertyOK() {
            clsStaff person = new clsStaff();
            person.Password = "qazwsx";
            Assert.AreEqual(person.Password, "qazwsx");
        }

        [TestMethod]
        public void HireDatePropertyOK() {
            clsStaff person = new clsStaff();
            person.HireDate = DateTime.Now.Date;
            Assert.AreEqual(person.HireDate, DateTime.Now.Date);
        }

        [TestMethod]
        public void IsActivePropertyOK() {
            clsStaff person = new clsStaff();
            person.IsActive = false;
            Assert.AreEqual(person.IsActive, false);
        }

        [TestMethod]
        public void AddTest0() {
            clsStaff staffMember = new clsStaff(4096, "Robert Jones", "admin", "martial arts", "chicken", new DateTime(2002, 8, 12), true);
            clsStaffCollection staffList = new clsStaffCollection();
            staffList.Add(staffMember);
            Assert.AreEqual(staffList.StaffList.Count, 1);
        }

        [TestMethod]
        public void AddTest1()
        {
            clsStaff staffMember = new clsStaff(4096, "Robert Jones", "admin", "martial arts", "chicken", DateTime.Now.Date, true);
            clsStaffCollection staffList = new clsStaffCollection();
            staffList.Add(staffMember);
            Assert.AreEqual(staffList.StaffList[0].Id, 4096);
            Assert.AreEqual(staffList.StaffList[0].Fullname, "Robert Jones");
            Assert.AreEqual(staffList.StaffList[0].Position, "admin");
            Assert.AreEqual(staffList.StaffList[0].Department, "martial arts");
            Assert.AreEqual(staffList.StaffList[0].Password, "chicken");
            Assert.AreEqual(staffList.StaffList[0].HireDate, DateTime.Now.Date);
            Assert.AreEqual(staffList.StaffList[0].IsActive, true);
        }

        [TestMethod]
        public void FindTest0()
        {
            clsStaff staffMember = new clsStaff(4096, "Robert Jones", "admin", "martial arts", "chicken", new DateTime(2002, 8, 12), true);
            clsStaffCollection staffList = new clsStaffCollection();
            staffList.Add(staffMember);
            Assert.IsNotNull(staffList.Find(4096));
        }

        [TestMethod]
        public void FindTest1() {
            clsStaffCollection staffList = new clsStaffCollection();
            Assert.IsNull(staffList.Find(4096));
        }

        [TestMethod]
        public void FindTest2() {
            clsStaff staffMember = new clsStaff(4096, "Robert Jones", "admin", "martial arts", "chicken", DateTime.Now.Date, true);
            clsStaffCollection staffList = new clsStaffCollection();
            staffList.Add(staffMember);
            var found = staffList.Find(4096);
            Assert.AreEqual(found.Id, 4096);
            Assert.AreEqual(found.Fullname, "Robert Jones");
            Assert.AreEqual(found.Position, "admin");
            Assert.AreEqual(found.Department, "martial arts");
            Assert.AreEqual(found.Password, "chicken");
            Assert.AreEqual(found.HireDate, DateTime.Now.Date);
            Assert.AreEqual(found.IsActive, true);
        }

        [TestMethod]
        public void DeleteTest0() {
            clsStaff staffMember = new clsStaff(4096, "Robert Jones", "admin", "martial arts", "chicken", DateTime.Now.Date, true);
            clsStaffCollection staffList = new clsStaffCollection();
            staffList.Add(staffMember);
            staffList.Delete(4096);
            Assert.AreEqual(staffList.StaffList.Count, 0);
        }

        [TestMethod]
        public void FilterTest0() {
            clsStaff staffMember0 = new clsStaff(4096, "Robert Jones", "admin", "martial arts", "chicken", DateTime.Now.Date, true);
            clsStaff staffMember1 = new clsStaff(1024, "Robert Jones", "seller", "martial arts", "chicken", DateTime.Now.Date, true);
            clsStaffCollection staffList = new clsStaffCollection();
            staffList.Add(staffMember0);
            staffList.Add(staffMember1);
            clsStaffCollection filtered = staffList.Filter(clsStaffCollection.filterAdmin);
            Assert.AreEqual(filtered.StaffList.Count, 1);
        }

        [TestMethod]
        public void FilterTest1() {
            clsStaff staffMember0 = new clsStaff(4096, "Mikhail Tal", "admin", "martial arts", "chicken", DateTime.Now.Date, false);
            clsStaff staffMember1 = new clsStaff(49374, "Bobby Fischer", "admin", "martial arts", "chicken", DateTime.Now.Date, false);
            clsStaff staffMember2 = new clsStaff(1024, "Robert Jones", "seller", "martial arts", "chicken", DateTime.Now.Date, true);
            clsStaffCollection staffList = new clsStaffCollection();
            staffList.Add(staffMember0);
            staffList.Add(staffMember1);
            staffList.Add(staffMember2);
            clsStaffCollection filteredStaff = staffList.Filter(person => person.IsActive);
            Assert.AreEqual(filteredStaff.StaffList.Count, 1);
        }

    }
}
