using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
    [TestClass]
    public class TstStock
    {
        string ProductDetails = "Male";
        string Price = "9.99";
        string InStock = "true";
        string DateAcquired = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            ClsStock AnStock = new ClsStock();
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void ProductIDOK()
        {
            ClsStock AnProduct = new ClsStock();
            Int32 TestData = 1;
            AnProduct.ProductId = TestData;
            Assert.AreEqual(AnProduct.ProductId, TestData);
        }
        [TestMethod]
        public void ProductDetailsOK()
        {
            ClsStock AnDetail = new ClsStock();
            String TestData = "50";
            AnDetail.ProductDetails = TestData;
            Assert.AreEqual(AnDetail.ProductDetails, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            ClsStock AnPrice = new ClsStock();
            Decimal TestData = 9.99M;
            AnPrice.Price = TestData;
            Assert.AreEqual(AnPrice.Price, TestData);
        }
        [TestMethod]
        public void DateAcquiredOK()
        {
            ClsStock Aquired = new ClsStock();
            DateTime TestData = DateTime.Now.Date;
            Aquired.DateAcquired = TestData;
            Assert.AreEqual(Aquired.DateAcquired, TestData);
        }
        [TestMethod]
        public void InStockOK()
        {
            ClsStock InStock = new ClsStock();
            Boolean TestData = true;
            InStock.Result = TestData;
            Assert.AreEqual(InStock.Result, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            ClsStock Stock = new ClsStock();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = Stock.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            ClsStock ProductID = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = ProductID.Find(ProductId);
            if (ProductID.ProductId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAcquiredFound()
        {
            ClsStock ProductID = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = ProductID.Find(ProductId);
            if (ProductID.DateAcquired != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductDetailsFound()
        {
            ClsStock ProductID = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = ProductID.Find(ProductId);
            if (ProductID.ProductDetails != "Male")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            ClsStock ProductID = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = ProductID.Find(ProductId);
            if (ProductID.Price != 9.99M)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestResultFound()
        {
            ClsStock ProductID = new ClsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = ProductID.Find(ProductId);
            if (ProductID.Result != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            ClsStock stock = new ClsStock();
            String Error = "";
            Error = stock.Valid(ProductDetails, DateAcquired, Price, InStock);
            Assert.AreEqual(Error, "");
        }
    }
}
