using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
	[TestClass]
	public class tstOrder
	{
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
            public void OrderNumberOK()
            {
                clsOrder AOrder = new clsOrder();
                Boolean TestData = true;
                AOrder.OrderCompleted = TestData;
                Assert.AreEqual(AOrder.OrderCompleted, TestData);
            }

        //OrderPrice
            [TestMethod]
            public void OrderNumberOK()
            {
                clsOrder AOrder = new clsOrder();
                float TestData = 6.9;
                AOrder.OrderPrice = TestData;
                Assert.AreEqual(AOrder.OrderPrice, TestData);
            }

        //CustomerID
            [TestMethod]
            public void OrderNumberOK()
            {
                clsOrder AOrder = new clsOrder();
                Int32 TestData = 2;
                AOrder.CustomerID = TestData;
                Assert.AreEqual(AOrder.CustomerID, TestData);
            }

        //StaffID
            [TestMethod]
            public void OrderNumberOK()
            {
                clsOrder AOrder = new clsOrder();
                Int32 TestData = 3;
                AOrder.OrderPrice = TestData;
                Assert.AreEqual(AOrder.OrderPrice, TestData);
            }

    }
    }

