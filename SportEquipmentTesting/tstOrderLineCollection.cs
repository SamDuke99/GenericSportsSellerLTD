using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstOrderLineCollection
    {
        //InstanceOK
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //Test to see that it exists
            Assert.IsNotNull(AllOrderLines);
        }

        //OrderLineListOK
        [TestMethod]
        public void OrderLineListOK()
        {
            //Create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //Add an item to the list
            //Create the item  of test data
            clsOrderLine TestItem = new clsOrderLine();
            //set its properties
            TestItem.OrderLineNumber = 1;
            TestItem.OrderNumber = 1;
            TestItem.ProductID = 1;
            TestItem.ProductQuantity = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrderLines.OrderLineList = TestList;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //Create some test data to assign to the property
            Int32 SomeCount = 0;
            //Assign the data to the property
            AllOrderLines.Count = SomeCount;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrderLines.Count, SomeCount);
        }

        //ThisOrderLinePropertyOK
        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestOrderLine = new clsOrderLine();
            TestOrderLine.OrderLineNumber = 1;
            TestOrderLine.OrderNumber = 1;
            TestOrderLine.ProductID = 1;
            TestOrderLine.ProductQuantity = 1;
            AllOrderLines.ThisOrderLine = TestOrderLine;
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestOrderLine);
        }

        //ListAndCountOK
        [TestMethod]
        public void ListAndCountOK()
        {
            //Create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //Create some test data to assign to the property
            //In this case the data needs to be a list of objects
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            //Add an item to the list
            //Create the item of the test data
            clsOrderLine TestItem = new clsOrderLine();
            //Set its properties
            TestItem.OrderNumber = 1;
            TestItem.ProductID = 1;
            TestItem.ProductQuantity = 1;
            //Add the item to the test list
            TestList.Add(TestItem);
            //Assign the data to the property
            AllOrderLines.OrderLineList = TestList;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);
        }

        //AddMethodOK
        [TestMethod]
        public void AddMethodOK()
        {
            //Create an instance of the class we want to create
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            //Create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set its properties
            TestItem.OrderLineNumber = 1;
            TestItem.OrderNumber = 1;
            TestItem.ProductID = 1;
            TestItem.ProductQuantity = 1;
            //Set ThisOrder to the test data
            AllOrderLines.ThisOrderLine = TestItem;
            //Add the record
            PrimaryKey = AllOrderLines.Add();
            //Set the primary key to the test data
            TestItem.OrderLineNumber = PrimaryKey;
            //Find the record
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            //Test to see that the 2 values are the same
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);
        }

        //DeleteMethodOK
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineNumber", mThisOrderLine.OrderLineNumber);
            DB.Execute("sproc_tblOrderLine_Delete");

            /*
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;

            TestItem.OrderLineNumber = 1;
            TestItem.OrderNumber = 1;
            TestItem.ProductID = 1;
            TestItem.ProductQuantity = 1;

            AllOrderLines.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLines.Add();
            TestItem.OrderLineNumber = PrimaryKey;
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            AllOrderLines.Delete();
            Boolean Found = AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            Assert.IsFalse(Found);
            */
        }

        //UpdateMethodOK
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;

            TestItem.OrderNumber = 1;
            TestItem.ProductID = 1;
            TestItem.ProductQuantity = 1;

            AllOrderLines.ThisOrderLine = TestItem;
            PrimaryKey = AllOrderLines.Add();

            TestItem.OrderLineNumber = PrimaryKey;
            TestItem.OrderNumber = 2;
            TestItem.ProductID = 2;
            TestItem.ProductQuantity = 2;

            AllOrderLines.ThisOrderLine = TestItem;
            AllOrderLines.Update();
            AllOrderLines.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);
        }

        //ReportByOrderNumber
        [TestMethod]
        public void ReportByOrderNumber()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
            
        }

        //ReportByOrderNumberNoneFound
        [TestMethod]
        public void ReportByOrderNumberNoneFound()
        {

        }

        //ReportByOrderNumberDataFound
        [TestMethod]
        public void ReportByOrderNumberDataFound()
        {
           //clsOrderLineCollection FilteredOrderLines = new clsOrderLineCollection();
           //Boolean OK = true;
            
        }

    }
}
