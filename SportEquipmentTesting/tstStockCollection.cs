using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;
using System.Collections.Generic;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection stockList = new clsStockCollection();
            Assert.IsNotNull(stockList);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection staffList = new clsStockCollection();
            List<clsStock> testList = new List<clsStock>();
            clsStock stock = new clsStock();
            stock.ProductId = 0;
            stock.ProductDetails = "Male";
            stock.DateAcquired = DateTime.Now.Date;
            stock.Price = 9.99M;
            stock.Result = true;
            testList.Add(stock);
            staffList.StockList = testList;
            Assert.AreEqual(staffList.StockList, testList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection stockList = new clsStockCollection();
            Int32 someCount = 0;
            Assert.AreNotEqual(someCount, stockList.Count);
        }



        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection stockList = new clsStockCollection();
            List<clsStock> testList = new List<clsStock>();
            clsStock stock = new clsStock();
            stock.ProductDetails = "Male";
            stock.DateAcquired = DateTime.Now.Date;
            stock.Price = 9.99M;
            stock.Result = true;
            testList.Add(stock);
            stockList.StockList = testList;
            Assert.AreEqual(stockList.Count, testList.Count);
        }

        [TestMethod]
        public void ReportByPositionDataFound()
        {
            clsStockCollection filteredCollection = new clsStockCollection();
            Boolean ok = true;
            filteredCollection.ReportByPosition("admin");

            if (filteredCollection.Count >= 2)
            {
                if (filteredCollection.StockList[0].ProductId != 1 || filteredCollection.StockList[1].ProductId != 10)
                    ok = false;
            }
            else
                ok = false;

            Assert.IsTrue(ok);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection stockList = new clsStockCollection();
            clsStock stock = new clsStock();
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
            clsStockCollection stockList = new clsStockCollection();
            clsStock stock = new clsStock();
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
            clsStockCollection stockList = new clsStockCollection();
            clsStock stock = new clsStock();
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
