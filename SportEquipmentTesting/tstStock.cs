using System;
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
        public void ProductIDOK()
        {
            clsStock AnProduct = new clsStock();
            Int32 TestData = 1;
            AnProduct.ProductId = TestData;
            Assert.AreEqual(AnProduct.ProductId, TestData);
        }
        public void ProductDetailsOK()
        {
            clsStock AnDetail = new clsStock();
            String TestData = "50";
            AnDetail.Detail = TestData;
            Assert.AreEqual(AnDetail.Detail, TestData);
        }
        public void PriceOK()
        {
            clsStock AnPrice = new clsStock();
            Decimal TestData = 9.99M;
            AnPrice.Price = TestData;
            Assert.AreEqual(AnPrice.Price, TestData);
        }
        public void DateAcquiredOK()
        {
            clsStock Aquired = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            Aquired.DateAcquired = TestData;
            Assert.AreEqual(Aquired.DateAcquired, TestData);
        }
        public void InStockOK()
        {
            clsStock InStock = new clsStock();
            Boolean TestData = true;
            InStock.Result = TestData;
            Assert.AreEqual(InStock.Result, TestData);
        }
        public void FindMethodOK()
        {
            clsStock AnDetail = new clsStock();
            Boolean Found = false;
            Int32 ProductID = 1;
            Found = AnDetail.Find(ProductID);
            Assert.IsTrue(Found);
        }
    }
}
