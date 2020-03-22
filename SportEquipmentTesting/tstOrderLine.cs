using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstOrderLine
    {
        //good test data
        string OrderNumber = "1";
        string ProductID = "1";
        string ProductQuantity = "1";

        //InstanceOK
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        //OrderLinNumberPropertyOK
        [TestMethod]
        public void OrderLinNumberPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderLineNumber = TestData;
            Assert.AreEqual(AnOrderLine.OrderLineNumber, TestData);

        }

        //OrderNumberPropertyOK
        [TestMethod]
        public void OrderNumberPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderNumber = TestData;
            Assert.AreEqual(AnOrderLine.OrderNumber, TestData);

        }

        //ProductIDPropertyOK
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.ProductID = TestData;
            Assert.AreEqual(AnOrderLine.ProductID, TestData);

        }

        //ProductQuantityPropertyOK
        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.ProductQuantity = TestData;
            Assert.AreEqual(AnOrderLine.ProductQuantity, TestData);

        }

        //FindMethod
        [TestMethod]
        public void FindMethod()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Int32 OrderLineNumber = 1;
            Found = AnOrderLine.Find(OrderLineNumber);
            Assert.IsTrue(Found);

        }

        //OrderLineNumberFound
        [TestMethod]
        public void OrderLineNumberFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderLineNumber = 21;
            Found = AnOrderLine.Find(OrderLineNumber);
            if (AnOrderLine.OrderLineNumber != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //OrderNumberFound
        [TestMethod]
        public void OrderNumberFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderNumber = 21;
            Found = AnOrderLine.Find(OrderNumber);
            if (AnOrderLine.OrderNumber != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //ProductIDFound
        [TestMethod]
        public void ProductIDFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductID = 1;
            Found = AnOrderLine.Find(ProductID);
            if (AnOrderLine.ProductID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        //ProductQuantityFound
        [TestMethod]
        public void ProductQuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductQuantity = 1;
            Found = AnOrderLine.Find(ProductQuantity);
            if (AnOrderLine.ProductQuantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        //ValidMethodOK
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreEqual(Error, "");

        }

        //Min - Max tests

    }
}
