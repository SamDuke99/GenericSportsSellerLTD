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
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Assert.IsNotNull(AllOrderLines);
        }

        //OrderLineListOK
        [TestMethod]
        public void OrderLineListOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineNumber = 1;
            TestItem.OrderNumber = 1;
            TestItem.ProductID = 1;
            TestItem.ProductQuantity = 1;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
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
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderNumber = 1;
            TestItem.ProductID = 1;
            TestItem.ProductQuantity = 1;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);
        }

        //AddMethodOK
        [TestMethod]
        public void AddMethodOK()
        {

        }

        //DeleteMethodOK
        [TestMethod]
        public void DeleteMethodOK()
        {

        }

        //UpdateMethodOK
        [TestMethod]
        public void UpdateMethodOK()
        {

        }

        //ReportByOrderNumber
        [TestMethod]
        public void ReportByOrderNumber()
        {

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

        }

    }
}
