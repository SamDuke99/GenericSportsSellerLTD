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
            clsOrder AOrder = new clsOrder();
            Int32 TestData = 1;
            AOrder.OrderNumber = TestData;
            Assert.AreEqual(AOrder.OrderNumber, TestData);
        }

        //OrderDescription
        [TestMethod]
        public void OrderDescriptionOK()
        {
            clsOrder AOrder = new clsOrder();
            string TestData = "123Test";
            AOrder.OrderDescription = TestData;
            Assert.AreEqual(AOrder.OrderDescription, TestData);
        }

        //OrderDatePlaced
        [TestMethod]
        public void OrderDatePlacedOK()
        {
            clsOrder AOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AOrder.OrderDatePlaced = TestData;
            Assert.AreEqual(AOrder.OrderDatePlaced, TestData);
        }

        //OrderCompleted
        [TestMethod]
        public void OrderCompletedOK()
        {
            clsOrder AOrder = new clsOrder();
            Boolean TestData = true;
            AOrder.OrderCompleted = TestData;
            Assert.AreEqual(AOrder.OrderCompleted, TestData);
        }

        //OrderPrice
        [TestMethod]
        public void OrderPriceOK()
        {
            clsOrder AOrder = new clsOrder();
            float TestData = 6;
            AOrder.OrderPrice = TestData;
            Assert.AreEqual(AOrder.OrderPrice, TestData);
        }

        //CustomerID
        [TestMethod]
        public void OrderCustomerIDOK()
        {
            clsOrder AOrder = new clsOrder();
            Int32 TestData = 2;
            AOrder.CustomerID = TestData;
            Assert.AreEqual(AOrder.CustomerID, TestData);
        }

        //StaffID
        [TestMethod]
        public void OrderStaffIDOK()
        {
            clsOrder AOrder = new clsOrder();
            Int32 TestData = 3;
            AOrder.StaffID = TestData;
            Assert.AreEqual(AOrder.StaffID, TestData);
        }

        //FindMethod
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderNumber = 1;
            Found = AOrder.Find(OrderNumber);
            Assert.IsTrue(Found);
        }

        //OrderNumberFound
        [TestMethod]
        public void TestOrderNumberFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 21;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderNumber != 21)
            {
                OK = false;
            }
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
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 21;
            Found = AOrder.Find(OrderNumber);
            if (AOrder.OrderDatePlaced != Convert.ToDateTime("16/09/2020"))
            {
                OK = false;
            }
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
            clsOrder AOrder = new clsOrder();
            String Error = "";
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted,
                OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreEqual(Error, "");
        }

        //OrderDescription Tests
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

        //OrderPrice Tests
        

    }
}