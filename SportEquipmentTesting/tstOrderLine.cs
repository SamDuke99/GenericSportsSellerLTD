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

        //OrderNumber
        //OrderNumberExtremeMin
        [TestMethod]
        public void OrderNumberExtremeMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = -100;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberMinMinus1
        [TestMethod]
        public void OrderNumberMinMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 0;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberMin
        [TestMethod]
        public void OrderNumberMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 1;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberMinPlus1
        [TestMethod]
        public void OrderNumberMinPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 2;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberMaxMinus1
        [TestMethod]
        public void OrderNumberMaxMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 9999;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberMax
        [TestMethod]
        public void OrderNumberMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 10000;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberMaxPlus1
        [TestMethod]
        public void OrderNumberMaxPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 10001;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberMid
        [TestMethod]
        public void OrderNumberMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 5000;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberExtremeMax
        [TestMethod]
        public void OrderNumberExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 100000;
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //OrderNumberInvalidData
        [TestMethod]
        public void OrderNumberInvalidData()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            String TestData = "This is not an int";
            String OrderNumber = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }

        //ProductID
        //ProductIDExtremeMin
        [TestMethod]
        public void ProductIDExtremeMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = -100;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDMinMinus1
        [TestMethod]
        public void ProductIDMinMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 0;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDMin
        [TestMethod]
        public void ProductIDMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 1;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDMinPlus1
        [TestMethod]
        public void ProductIDMinPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 2;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDMaxMinus1
        [TestMethod]
        public void ProductIDMaxMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 9999;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDMax
        [TestMethod]
        public void ProductIDMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 10000;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDMaxPlus1
        [TestMethod] 
        public void ProductIDMaxPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 10001;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDMid
        [TestMethod]
        public void ProductIDMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 5000;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDExtremeMax
        [TestMethod]
        public void ProductIDExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 100000;
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductIDInvalidData
        [TestMethod]
        public void ProductIDInvalidData()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            String TestData = "This is not a string";
            String ProductID = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }

        //ProductQuantity
        //ProductQuantityExtremeMin
        [TestMethod]
        public void ProductQuantityExtremeMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = -100;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityMinMinus1
        [TestMethod]
        public void ProductQuantityMinMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 0;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityMin
        [TestMethod]
        public void ProductQuantityMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 1;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityMinPlus1
        [TestMethod]
        public void ProductQuantityMinPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 2;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityMaxMinus1
        [TestMethod]
        public void ProductQuantityMaxMinus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 9999;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityMax
        [TestMethod]
        public void ProductQuantityMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 10000;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityMaxPlus1
        [TestMethod]
        public void ProductQuantityMaxPlus1()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 10001;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityMid
        [TestMethod]
        public void ProductQuantityMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 5000;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityExtremeMax
        [TestMethod]
        public void ProductQuantityExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            int TestData = 100000;
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }
        //ProductQuantityInvalidData
        [TestMethod]
        public void ProductQuantityInvalidData()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = "";
            String TestData = "This is not a int";
            String ProductQuantity = TestData.ToString();
            Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
            Assert.AreNotEqual(Error, "");
        }




    }
}
