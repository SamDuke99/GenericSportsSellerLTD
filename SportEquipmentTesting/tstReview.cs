using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SportEquipmentTesting
{
    [TestClass]
    public class tstReview
    {
        [TestMethod]
        public void InstanceOK()
            
        {
            clsReview AReview = new clsReview();
            Assert.IsNotNull(AReview);

        }

        [TestMethod]
        public void ReviewTrustedPropertyOk()
        {
            clsReview AReview = new clsReview();
            Boolean TestData = true;
            Review.ReviewTrusted = TestData;
            Assert.AreEqual(AReview.ReviewTrusted, TestData);

        }

        [TestMethod]
        public void ReviewDatePostedPropertyOK()
            
        {
            clsReview AReview = new clsReview();
            DateTime TestData = DateTime.Now.Date;
            AReview.ReviewDatePosted = TestData;
            Assert.AreEqual(AReview.ReviewDatePosted, TestData);
        }
