using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff guy = new clsStaff();
            Assert.IsNotNull(guy);
        }
    }
}
