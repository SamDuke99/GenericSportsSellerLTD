using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;
using System.Collections.Generic;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNumber = 1;
            TestItem.OrderDescription = "abc";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = false;
            TestItem.OrderPrice = (float)6.67;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderNumber = 2;
            TestOrder.OrderDescription = "abcd";
            TestOrder.OrderDatePlaced = DateTime.Now.Date;
            TestOrder.OrderCompleted = false;
            TestOrder.OrderPrice = (float)5.67;
            TestOrder.CustomerID = 2;
            TestOrder.StaffID = 2;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderNumber = 1;
            TestItem.OrderDescription = "abce";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = false;
            TestItem.OrderPrice = (float)4.67;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.OrderNumber = 1;
            TestItem.OrderDescription = "abc";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = false;
            TestItem.OrderPrice = (float)1.11;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNumber = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;

            TestItem.OrderNumber = 1;
            TestItem.OrderDescription = "abc";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = false;
            TestItem.OrderPrice = (float)1.11;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNumber = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
         
            TestItem.OrderDescription = "abc";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = false;
            TestItem.OrderPrice = (float)1.11;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;

            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNumber = PrimaryKey;

            TestItem.OrderDescription = "abcd";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = true;
            TestItem.OrderPrice = (float)1.19;
            TestItem.CustomerID = 2;
            TestItem.StaffID = 2;

            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ReportByOrderDescription()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderDescription("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderDescriptionNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByOrderDescription("xxx xxx");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderDescriptionDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByOrderDescription("testOD 123");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderNumber != 21)
                {
                    OK = false;
                }
                if(FilteredOrders.OrderList[0].OrderNumber != 22)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
