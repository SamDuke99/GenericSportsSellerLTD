using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstOrder
    {

        //good test data
        String OrderDescription = "plenty of items";
        String OrderDatePlaced = DateTime.Now.Date.ToString();
        String OrderCompleted = "true";
        String OrderPrice = "9.9";
        String OrderCustomerID = "1";
        String OrderStaffID = "1";


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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AOrder = new clsOrder();
            String Error = "";
            Error = AOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted,
                OrderPrice, OrderCustomerID, OrderStaffID);
            Assert.AreEqual(Error, "");
        }

    }
}