using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEquipmentClasses;

namespace SportEquipmentTesting
{
	[TestClass]
	public class tstOrder
	{
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsOrder AOrder = new clsOrder();
                //test to see that it exists
                Assert.IsNotNull(AOrder);
            }




        }
    }

