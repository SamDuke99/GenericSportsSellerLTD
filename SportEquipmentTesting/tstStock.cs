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
            String TestData = 50;
            AnDetail.ProductId = TestData;
            Assert.AreEqual(AnDetail.ProductId, TestData);
        }
        public void PriceOK()
        {
            clsStock AnPrice = new clsStock();
            Decimal TestData = 9.99;
            AnPrice.ProductId = TestData;
            Assert.AreEqual(AnPrice.ProductId, TestData);
        }
        public void DateAcquiredOK()
        {
            clsStock Aquired = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            Aquired.ProductId = TestData;
            Assert.AreEqual(Aquired.ProductId, TestData);
        }
        public void InStockOK()
        {
            clsStock AnStock = new clsStock();
            Boolean TestData = true;
            AnStock.ProductId = TestData;
            Assert.AreEqual(AnStock.ProductId, TestData);
        }
}
