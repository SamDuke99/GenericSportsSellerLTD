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
            if (staffMember.Password != "chicken1")
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
            if (staffMember.Department != "martial")
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

        [TestMethod]
        public void StaffIdOther1()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "1; DROP DATABASE xyz";
            string errorMsg = staffMember.ValidId(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameMinOneLess()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "";
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameMin()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "a";
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameMax()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(32, 'a');
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameMaxOneLess()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(31, 'a');
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameMaxOneMore()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(33, 'a');
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameMinOneMore()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "aa";
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameOther0()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "Żółć";
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameOthr1()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "<script>alert(1);</script>";
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameInvalid1()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "10/11/19";
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameMid()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(17, 'a');
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffFullnameExtremeMx()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(64, 'a');
            string errorMsg = staffMember.ValidFullname(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMin()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "";
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordMinOneLess()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "aaaaaaa";
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordMin()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "aaaaaaaa";
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordMinOneMore()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "aaaaaaaaa";
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordMaxOneLess()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(33, 'a');
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordMax()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(32, 'a');
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordMid()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(20, 'a');
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordExtremeMax()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "".PadRight(64, 'a');
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordInvalid0()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "11/12/2015";
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordOther0()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "Łódź";
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPasswordOther1()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "chicken' OR 1=1 -- ";
            string errorMsg = staffMember.ValidPassword(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPositionTest0()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "seller";
            string errorMsg = staffMember.ValidPosition(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPositionTest1()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "drone";
            string errorMsg = staffMember.ValidPosition(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffPositionTest2()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "<img src=”asdf.png” onerror=”alert(1);”>";
            string errorMsg = staffMember.ValidPosition(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffDepartmentTest0()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "martial";
            string errorMsg = staffMember.ValidDepartment(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffDepartmentTest1()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "earnest";
            string errorMsg = staffMember.ValidDepartment(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void StaffDepartmentTest2()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "'; DROP USER xyz";
            string errorMsg = staffMember.ValidDepartment(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateExtremeMin()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "01/01/0000";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateMin()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "01/01/0001";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateMinOneMore()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "12/12/2012";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateMaxOneLess()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "31/12/9998";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateMax()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "31/12/9999";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateMid()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "15/06/5000";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateInvalidType()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "string";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateOther0()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "32/12/2012";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }

        [TestMethod]
        public void HireDateOther1()
        {
            clsStaff staffMember = new clsStaff();
            string testValue = "31/13/2012";
            string errorMsg = staffMember.ValidHireDate(testValue);
            Assert.AreNotEqual(errorMsg, "");
        }
    }
        
}
