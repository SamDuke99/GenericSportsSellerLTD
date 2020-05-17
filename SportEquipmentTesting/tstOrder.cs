using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        string OrderDescription = "plenty of items";
        string OrderDatePlaced = DateTime.Now.Date.ToString();
        string OrderCompleted = "true";
        string OrderPrice = "9.9";
        string OrderCustomerID = "1";
        string OrderStaffID = "1";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AOrder);
        }

        //OrderNumber
        [TestMethod]
        public void OrderNumberOK()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the test data to the property
            AOrder.OrderNumber = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AOrder.OrderNumber, TestData);
        }

        //OrderDescription
        [TestMethod]
        public void OrderDescriptionOK()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Create some test data to assign to the property
            string TestData = "123Test";
            //Assign the test data to the property
            AOrder.OrderDescription = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AOrder.OrderDescription, TestData);
        }

        //OrderDatePlaced
        [TestMethod]
        public void OrderDatePlacedOK()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the test data to the property
            AOrder.OrderDatePlaced = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AOrder.OrderDatePlaced, TestData);
        }

        //OrderCompleted
        [TestMethod]
        public void OrderCompletedOK()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Create some test data to assign to the property
            Boolean TestData = true;
            //Assign the test data to the property
            AOrder.OrderCompleted = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AOrder.OrderCompleted, TestData);
        }

        //OrderPrice
        [TestMethod]
        public void OrderPriceOK()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Create some test data to assign to the property
            float TestData = 6.9F;
            //Assign the test data to the property
            AOrder.OrderPrice = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AOrder.OrderPrice, TestData);
        }

        //CustomerID
        [TestMethod]
        public void OrderCustomerIDOK()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Create some test data to assign to the property
            Int32 TestData = 2;
            //Assign the test data to the property
            AOrder.CustomerID = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AOrder.CustomerID, TestData);
        }

        //StaffID
        [TestMethod]
        public void OrderStaffIDOK()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Create some test data to assign to the property
            Int32 TestData = 3;
            //Assign the test data to the property
            AOrder.StaffID = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AOrder.StaffID, TestData);
        }

        //FindMethod
        [TestMethod]
        public void FindMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the record
            Int32 OrderNumber = 1;
            //Invoke the method
            Found = AOrder.Find(OrderNumber);
            //Test to see that the result is correct
            Assert.IsTrue(Found);
        }

        //OrderNumberFound
        [TestMethod]
        public void TestOrderNumberFound()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //Boolan variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the record
            Int32 OrderNumber = 2;
            //Invoke the method
            Found = AOrder.Find(OrderNumber);
            //Check the OrderNumber
            if (AOrder.OrderNumber != 2)
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //OrderDescription Found
        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 21;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderDescription != "testOD 123")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //OrderDatePlaced 
        [TestMethod]
        public void TestOrderDatePlacedFound()
        {
            //Create an instance of the class we want to create
            clsOrder AOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the method
            Int32 OrderNumber = 2;
            //Invoke the method
            Found = AOrder.Find(OrderNumber);
            //Check the property
            if (AOrder.OrderDatePlaced != Convert.ToDateTime("16/09/2020"))
            {
                OK = false;
            }
            //Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        //OrderCompleted 
        [TestMethod]
        public void TestOrderCompletedFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 21;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderCompleted != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //OrderPrice 
        [TestMethod]
        public void TestOrderPriceFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 21;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderPrice != 9)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //CustomerID
        [TestMethod]
        public void TestOrderCustomerIDFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 21;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderPrice != 34)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //StaffID
        [TestMethod]
        public void TestOrderStaffIDFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 21;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderPrice != 55)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //ValidMethodOK
        [TestMethod]
        public void ValidMethodOK()
        {
            //Create an instance of the classs we want to create
            clsOrder AOrder = new clsOrder();
            //String variable to store any error message
            String Error = "";
            //Invoke the method
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted,
                OrderPrice, OrderCustomerID, OrderStaffID);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //OrderDescription Tests Done
        //OrderDescriptionMinLessOne
        //OrderDescriptionMin
        //OrderDecriptionMinPlusOne
        //OrderDecriptionMaxLessOne
        //OrderDecriptionMax
        //OrderDecriptionMaxPlusOne
        //OrderDecriptionMid
        //OrderDecriptionExtremeMax
        [TestMethod]
        public void OrderDescriptionMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "";
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDescriptionMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "a";
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDecriptionMinPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "ab";
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDecriptionMaxLessOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            //50 max 
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(49, 'a');
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDecriptionMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            //50 max 
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(50, 'a');
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDecriptionMaxPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            //50 max. This should fail! 
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(51, 'a');
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDecriptionMid()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            //50 max 
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(25, 'a');
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDecriptionExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "";
            //This should fail! 
            OrderDescription = OrderDescription.PadRight(500, 'a');
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        //OrderDatePlaced Tests
        //OrderDatePlacedExtremeMin
        //OrderDatePlacedMinLessOne
        //OrderDatePlacedMin
        //OrderDatePlacedMinPlusOne
        //OrderDatePlacedExtremeMax
        //OrderDatePlacedInvalidData
        [TestMethod]
        public void OrderDatePlacedExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            String OrderDatePlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDatePlacedMinLessOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            String OrderDatePlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDatePlacedMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            String OrderDatePlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDatePlacedMinPlusOne()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            String OrderDatePlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDatePlacedExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            String OrderDatePlaced = TestDate.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDatePlacedInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String OrderDatePlaced = "this is not a date!";
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        //OrderCompleted
        //OrderCompletedMin
        [TestMethod]
        public void OrderCompletedMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            Boolean TestData = false;
            String OrderCompleted = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //OrderCompletedMax
        [TestMethod]
        public void OrderCompletedMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            Boolean TestData = true;
            String OrderCompleted = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //OrderCompletedInvalidData
        [TestMethod]
        public void OrderCompletedInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String TestData = "this is not a boolean!";
            String OrderCompleted = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        //OrderPrice Tests
        //OrderPriceExtremeMin
        [TestMethod]
        public void OrderPriceExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = -1000.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        //OrderPriceMinMinus1
        [TestMethod]
        public void OrderPriceMinMinus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = -1.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //OrderPriceMin
        [TestMethod]
        public void OrderPriceMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = 0.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //OrderPriceMinPlus1
        [TestMethod]
        public void OrderPriceMinPlus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = 1.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");

        }
        //OrderPriceMaxMinus1
        [TestMethod]
        public void OrderPriceMaxMinus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = 999.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //OrderPriceMax
        [TestMethod]
        public void OrderPriceMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = 1000.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");

        }
        //OrderPriceMaxPlus1
        [TestMethod]
        public void OrderPriceMaxPlus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = 1001.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //OrderPriceMid
        [TestMethod]
        public void OrderPriceMid()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = 500.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //OrderPriceExtremeMax
        [TestMethod]
        public void OrderPriceExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            float TestData = 10000.0F;
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //OrderPriceInvalidData
        [TestMethod]
        public void OrderPriceInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String TestData = "this is not a float!";
            String OrderPrice = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        //CustomerID
        //CustomerIDExtremeMin
        [TestMethod]
        public void CustomerIDExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = -100;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDMinMinus1
        [TestMethod]
        public void CustomerIDMinMinus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 0;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDMin
        [TestMethod]
        public void CustomerIDMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 1;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDMinPlus1
        [TestMethod]
        public void CustomerIDMinPlus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 2;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDMaxMinus1
        [TestMethod]
        public void CustomerIDMaxMinus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 9999;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDMax
        [TestMethod]
        public void CustomerIDMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 10000;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDMaxPlus1
        [TestMethod]
        public void CustomerIDMaxPlus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 10001;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDMid
        [TestMethod]
        public void CustomerIDMid()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 5000;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDExtremeMax
        [TestMethod]
        public void CustomerIDExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 100000;
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //CustomerIDInvalidData
        [TestMethod]
        public void CustomerIDInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String TestData = "This is not an integer";
            String CustomerID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }

        //StaffID
        //StaffIDExtremeMin
        [TestMethod]
        public void StaffIDExtremeMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = -100;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDMinMinus1
        [TestMethod]
        public void StaffIDMinMinus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 0;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDMin
        [TestMethod]
        public void StaffIDMin()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 1;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDMinPlus1
        [TestMethod]
        public void StaffIDMinPlus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 2;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDMaxMinus1
        [TestMethod]
        public void StaffIDMaxMinus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 9999;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDMax
        [TestMethod]
        public void StaffIDMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 10000;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDMaxPlus1
        [TestMethod]
        public void StaffIDMaxPlus1()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 10001;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDMid
        [TestMethod]
        public void StaffIDMid()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 5000;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDExtremeMax
        [TestMethod]
        public void StaffIDExtremeMax()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            int TestData = 100000;
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }
        //StaffIDInvalidData
        [TestMethod]
        public void StaffIDInvalidData()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            String TestData = "This is not an int";
            String StaffID = TestData.ToString();
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted, OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreNotEqual(Error, "");
        }


    }
}