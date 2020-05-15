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
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        //OrderLineNumberPropertyOK
        [TestMethod]
        public void OrderLineNumberPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the test data to the property
            AnOrderLine.OrderLineNumber = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AnOrderLine.OrderLineNumber, TestData);
        }

        //OrderNumberPropertyOK
        [TestMethod]
        public void OrderNumberPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the test data to the property
            AnOrderLine.OrderNumber = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AnOrderLine.OrderNumber, TestData);

        }

        //ProductIDPropertyOK
        [TestMethod]
        public void ProductIDPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the test data to the property
            AnOrderLine.ProductID = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AnOrderLine.ProductID, TestData);

        }

        //ProductQuantityPropertyOK
        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            //Create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //Assign the test data to the property
            AnOrderLine.ProductQuantity = TestData;
            //Test to see that the 2 values are the same
            Assert.AreEqual(AnOrderLine.ProductQuantity, TestData);

        }

        //FindMethod
        [TestMethod]
        public void FindMethod()
        {
            //Create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to use with the record
            Int32 OrderLineNumber = 1;
            //Invoke the method
            Found = AnOrderLine.Find(OrderLineNumber);
            //Test to see that the result is correct
            Assert.IsTrue(Found);

        }

        //OrderLineNumberFound
        [TestMethod]
        public void OrderLineNumberFound()
        {
            //Create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //Boolan variable to store the result of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //Create some test data to use with the record
            Int32 OrderLineNumber = 2;
            //Invoke the method
            Found = AnOrderLine.Find(OrderLineNumber);
            //Check the OrderLineNumber
            if (AnOrderLine.OrderLineNumber != 2)
            {
                OK = false;
            }
            //Test to see that the result is correct
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
            //Create an instance of the classs we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //String variable to store any error message
            String Error = "";
            //Invoke the method
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            //Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        //Min - Max tests

    }
}
