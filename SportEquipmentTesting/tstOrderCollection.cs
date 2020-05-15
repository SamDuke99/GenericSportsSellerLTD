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
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //Create the item  of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.OrderNumber = 1;
            TestItem.OrderDescription = "abc";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = false;
            TestItem.OrderPrice = (float)6.67;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrders.OrderList = TestList;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            Int32 SomeCount = 0;
            //Assign the data to the property
            AllOrders.Count = SomeCount;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderNumber = 2;
            TestOrder.OrderDescription = "abcd";
            TestOrder.OrderDatePlaced = DateTime.Now.Date;
            TestOrder.OrderCompleted = false;
            TestOrder.OrderPrice = (float)5.67;
            TestOrder.CustomerID = 2;
            TestOrder.StaffID = 2;
            //Assign the data to the property
            AllOrders.ThisOrder = TestOrder;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //Add an item to the list
            //Create the item of the test data
            clsOrder TestItem = new clsOrder();
            //Set its properties
            TestItem.OrderNumber = 1;
            TestItem.OrderDescription = "abce";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = false;
            TestItem.OrderPrice = (float)4.67;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrders.OrderList = TestList;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void TwoRecordsPresent()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.Count, 2);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create the item of test data
            clsOrder TestItem = new clsOrder();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.OrderNumber = 1;
            TestItem.OrderDescription = "abc";
            TestItem.OrderDatePlaced = DateTime.Now.Date;
            TestItem.OrderCompleted = false;
            TestItem.OrderPrice = (float)1.11;
            TestItem.CustomerID = 1;
            TestItem.StaffID = 1;
            //Set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrders.Add();
            //Set the primary key to the test data
            TestItem.OrderNumber = PrimaryKey;
            //Find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            DB.Execute("sproc_tblOrder_Delete");

            /*
            //Create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //Create the item of test data
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
            */
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
