using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        //OrderLineNumber
        [TestMethod]
        public void OrderLineNumberOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderLineNumber = TestData;
            Assert.AreEqual(AnOrderLine.OrderLineNumber, TestData);
        }

        //OrderNumber
        [TestMethod]
        public void OrderNumberOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 2;
            AnOrderLine.OrderNumber = TestData;
            Assert.AreEqual(AnOrderLine.OrdereNumber, TestData);
        }

        //ProductID
        [TestMethod]
        public void OrderProductIDOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 3;
            AnOrderLine.ProductID = TestData;
            Assert.AreEqual(AnOrderLine.ProductID, TestData);
        }

    }
}
