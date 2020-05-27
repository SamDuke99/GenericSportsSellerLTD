﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }
        [TestMethod]
        public void ProductIDOK()
        {
            clsStock AnProduct = new clsStock();
            Int32 TestData = 1;
            AnProduct.ProductId = TestData;
            Assert.AreEqual(AnProduct.ProductId, TestData);
        }
        [TestMethod]
        public void ProductDetailsOK()
        {
            clsStock AnDetail = new clsStock();
            String TestData = "50";
            AnDetail.ProductDetails = TestData;
            Assert.AreEqual(AnDetail.ProductDetails, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            clsStock AnPrice = new clsStock();
            Decimal TestData = 9.99M;
            AnPrice.Price = TestData;
            Assert.AreEqual(AnPrice.Price, TestData);
        }
        [TestMethod]
        public void DateAcquiredOK()
        {
            clsStock Aquired = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            Aquired.DateAcquired = TestData;
            Assert.AreEqual(Aquired.DateAcquired, TestData);
        }
        [TestMethod]
        public void InStockOK()
        {
            clsStock InStock = new clsStock();
            Boolean TestData = true;
            InStock.Result = TestData;
            Assert.AreEqual(InStock.Result, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AnDetail = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = AnDetail.Find(ProductID);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            clsStock ProductID = new clsStock();
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
            clsStock ProductID = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = ProductID.Find(ProductId);
            if (ProductID.DateAcquired != Convert.ToDateTime("16/9/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductDetailsFound()
        {
            clsStock ProductID = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductId = 1;
            Found = ProductID.Find(ProductId);
            if (ProductID.ProductDetails != "Mens")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsStock ProductID = new clsStock();
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
            clsStock ProductID = new clsStock();
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
    }
}
