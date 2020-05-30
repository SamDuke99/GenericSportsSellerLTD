using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;
using System.Collections.Generic;

namespace SportEquipmentTesting
{
    [TestClass]
    public class TstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            ClsStockCollection stockList = new ClsStockCollection();
            Assert.IsNotNull(stockList);
        }

        [TestMethod]
        public void StockListOK()
        {
            ClsStockCollection staffList = new ClsStockCollection();
            List<ClsStock> testList = new List<ClsStock>();
            ClsStock stock = new ClsStock
            {
                ProductId = 0,
                ProductDetails = "Male",
                DateAcquired = DateTime.Now.Date,
                Price = 9.99M,
                Result = true
            };
            testList.Add(stock);
            staffList.StockList = testList;
            Assert.AreEqual(staffList.StockList, testList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            ClsStockCollection stockList = new ClsStockCollection();
            Int32 someCount = 0;
            Assert.AreNotEqual(someCount, stockList.Count);
        }



        [TestMethod]
        public void ListAndCountOK()
        {
            ClsStockCollection stockList = new ClsStockCollection();
            List<ClsStock> testList = new List<ClsStock>();
            ClsStock stock = new ClsStock
            {
                ProductDetails = "Male",
                DateAcquired = DateTime.Now.Date,
                Price = 9.99M,
                Result = true
            };
            testList.Add(stock);
            stockList.StockList = testList;
            Assert.AreEqual(stockList.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            ClsStockCollection stockList = new ClsStockCollection();
            ClsStock stock = new ClsStock();
            Int32 primaryKey = 0;
            stock.ProductDetails = "Male";
            stock.DateAcquired = DateTime.Now;
            stock.Price = 9.99M;
            stock.Result = true;

            stockList.ThisProduct = stock;
            primaryKey = stockList.Add();
            stock.ProductId = primaryKey;
            stockList.ThisProduct.Find(primaryKey);
            Assert.AreEqual(stockList.ThisProduct, stock);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            ClsStockCollection stockList = new ClsStockCollection();
            ClsStock stock = new ClsStock();
            Int32 primaryKey = 0;
            stock.ProductDetails = "Male";
            stock.DateAcquired = DateTime.Now.Date;
            stock.Price = 9.99M;
            stock.Result = true;
            stockList.ThisProduct = stock;
            primaryKey = stockList.Add();
            stock.ProductId = primaryKey;
            stockList.Delete();
            Boolean found = stockList.ThisProduct.Find(primaryKey);
            Assert.IsFalse(found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            ClsStockCollection stockList = new ClsStockCollection();
            ClsStock stock = new ClsStock();
            Int32 primaryKey;
            stock.ProductDetails = "Male";
            stock.DateAcquired = DateTime.Now.Date;
            stock.Price = 9.99M;
            stock.Result = true;
            stockList.ThisProduct = stock;
            primaryKey = stockList.Add();
            stock.ProductId = primaryKey;
            stock.ProductDetails = "Female";
            stock.DateAcquired = DateTime.Now.Date;
            stock.Price = 8.88M;
            stock.Result = false;
            stockList.ThisProduct = stock;
            stockList.Update();
            stockList.ThisProduct.Find(primaryKey);
            Assert.AreEqual(stockList.ThisProduct, stock);
        }

    }
}
