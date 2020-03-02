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

        //ProductDetails
        //Price
        //DateAcquired
        //InStock
    }

}
