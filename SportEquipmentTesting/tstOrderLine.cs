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

        }

        //OrderNumberPropertyOK
        [TestMethod]
        public void OrderNumberPropertyOK()
        {

        }

        //ProductIDPropertyOK
        [TestMethod]
        public void ProductIDPropertyOK()
        {

        }

        //FindMethod
        [TestMethod]
        public void FindMethod()
        {

        }

        //OrderLineNumberFound
        [TestMethod]
        public void OrderLineNumberFound()
        {

        }

        //OrderNumberFound
        [TestMethod]
        public void OrderNumberFound()
        {

        }

        //ProductIDFound
        [TestMethod]
        public void ProductIDFound()
        {

        }

        //ValidMethodOK
        [TestMethod]
        public void ValidMethodOK()
        {

        }

        //Min - Max tests

    }
}
