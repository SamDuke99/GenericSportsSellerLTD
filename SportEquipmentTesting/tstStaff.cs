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
        public void FullNamePropertyOK()
        {
            clsStaff person = new clsStaff();
            person.Fullname = "Mikhail Tal";
            Assert.AreEqual(person.Fullname, "Mikhail Tal");
        }

        [TestMethod]
        public void PositionPropertyOK()
        {
            clsStaff person = new clsStaff();
            person.Position = "admin";
            Assert.AreEqual(person.Position, "admin");
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStaff person = new clsStaff();
            person.Department = "martial arts";
            Assert.AreEqual(person.Department, "martial arts");
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStaff person = new clsStaff();
            person.Password = "qazwsx";
            Assert.AreEqual(person.Password, "qazwsx");
        }

        [TestMethod]
        public void HireDatePropertyOK()
        {
            clsStaff person = new clsStaff();
            person.HireDate = DateTime.Now.Date;
            Assert.AreEqual(person.HireDate, DateTime.Now.Date);
        }

        [TestMethod]
        public void IsActivePropertyOK()
        {
            clsStaff person = new clsStaff();
            person.IsActive = false;
            Assert.AreEqual(person.IsActive, false);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff staffMember = new clsStaff();
            bool found = false;
            int staffId = 1;
            found = staffMember.Find(staffId);
            Assert.IsTrue(found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff staffMember = new clsStaff();
            bool found = false;
            bool ok = true;
            int staffId = 1;
            found = staffMember.Find(staffId);
            if (staffMember.Id != 1)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffFullnameFound()
        {
            clsStaff staffMember = new clsStaff();
            bool found = false;
            bool ok = true;
            int staffId = 1;
            found = staffMember.Find(staffId);
            if (staffMember.Fullname != "Robert Lewandowski")
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffPasswordFound()
        {
            clsStaff staffMember = new clsStaff();
            bool found = false;
            bool ok = true;
            int staffId = 1;
            found = staffMember.Find(staffId);
            if (staffMember.Password != "chicken")
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffHireDateFound()
        {
            clsStaff staffMember = new clsStaff();
            bool found = false;
            bool ok = true;
            int staffId = 1;
            found = staffMember.Find(staffId);
            if (staffMember.HireDate != Convert.ToDateTime("16/12/2002"))
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffPosition()
        {
            clsStaff staffMember = new clsStaff();
            bool found = false;
            bool ok = true;
            int staffId = 1;
            found = staffMember.Find(staffId);
            if (staffMember.Position != "admin")
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffDepartment()
        {
            clsStaff staffMember = new clsStaff();
            bool found = false;
            bool ok = true;
            int staffId = 1;
            found = staffMember.Find(staffId);
            if (staffMember.Department != "asdf")
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void TestStaffIsActive()
        {
            clsStaff staffMember = new clsStaff();
            bool found = false;
            bool ok = true;
            int staffId = 1;
            found = staffMember.Find(staffId);
            if (!staffMember.IsActive)
            {
                ok = false;
            }

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void StaffIdExtremeMin()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "-16";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "-1";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdMinBoundry()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "0";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdMinOneMore()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "1";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdExtremeMax()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "1024";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdMaxBoundry()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "256";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdMaxOneLess()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "255";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdMaxOneMore()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "257";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdMid()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "128";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdInvalid0()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "Abc";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdInvalid1()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = staffMember.ToString();
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdInvalid2()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = DateTime.Now.ToString();
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdInvalid3()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "0x34";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffIdOther0()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }
    }
        
}
