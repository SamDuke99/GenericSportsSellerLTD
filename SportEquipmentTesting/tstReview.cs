using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsReview AReview = new clsReview();
            Assert.IsNotNull(AReview);

        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            clsReview AReview = new clsReview();
            Boolean TestData = true;
            Review.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);

        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateAdded = TestData;
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestClass]
        public class tstAddress
        {
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //test to see that it exists
                Assert.IsNotNull(ACustomer);
            }

            [TestMethod]
            public void ActivePropertyOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //create some test data to assign to the property
                Boolean TestData = true;
                //assign the data to the property
                ACustomer.Active = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(ACustomer.Active, TestData);
            }

            [TestMethod]
            public void DateAddedPropertyOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //create some test data to assign to the property
                DateTime TestData = DateTime.Now.Date;
                //assign the data to the property
                ACustomer.DateAdded = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(ACustomer.DateAdded, TestData);
            }


            [TestMethod]
            public void AddressNoPropertyOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //create some test data to assign to the property
                Int32 TestData = 1;
                //assign the data to the property
                ACustomer.AddressNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(ACustomer.AddressNo, TestData);
            }

            [TestMethod]
            public void CountyNoPropertyOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //create some test data to assign to the property
                Int32 TestData = 1;
                //assign the data to the property
                ACustomer.CountyNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(ACustomer.CountyNo, TestData);
            }

            [TestMethod]
            public void HouseNoPropertyOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //create some test data to assign to the property
                string TestData = "21b";
                //assign the data to the property
                ACustomer.HouseNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(ACustomer.HouseNo, TestData);
            }

            [TestMethod]
            public void PostCodePropertyOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //create some test data to assign to the property
                string TestData = "LE1 4AB";
                //assign the data to the property
                ACustomer.PostCode = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(ACustomer.PostCode, TestData);
            }

            [TestMethod]
            public void StreetPropertyOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //create some test data to assign to the property
                string TestData = "Some Street";
                //assign the data to the property
                ACustomer.Street = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(ACustomer.Street, TestData);
            }

            [TestMethod]
            public void TownPropertyOK()
            {
                //create an instance of the class we want to create
                clsCustomer ACustomer = new clsCustomer();
                //create some test data to assign to the property
                string TestData = "Leicester";
                //assign the data to the property
                ACustomer.Town = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(ACustomer.Town, TestData);
            }


        }
    }
