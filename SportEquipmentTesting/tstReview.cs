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
    
          [TestMethod]
        public void CustomerIDOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            
            //create some test data to assign to the property
            Int32 TestData = 2;
            
            //assign the data to the property
            ACustomer.CustomerID = TestData;
            
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
        
          [TestMethod]
        public void ReviewIDOK()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property
            AReview.ReviewID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AReview.ReviewID, TestData);
        }
        
        [TestMethod]
        public void ReviewContentOK()
        {
            //create an instance of the class we want to create
            clsReview AReview = new clsReview();
            
            //create some test data to assign to the property
            string TestData = "Twas great";
            
            //assign the data to the property
            AReview.ReviewContent = TestData;
            
            //test to see that the two values are the same
            Assert.AreEqual(AReview.ReviewContent, TestData);
        }
        
        [TestMethod]
        public void ReviewRatingOK()
            
        {
            clsReview AReview = new clsReview();
            Decimal TestData = 5.0;
            AnPrice.ReviewRating = TestData;
            Assert.AreEqual(AReview.ReviewRating, TestData);
        }
        
        [TestMethod]
        public void FindMethodOK()
            
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            clsReview AReview = new clsReview();
            //boolean to store the result of the validation 
            Boolean Found = false;
            Boolean Look = false;
            //create some test data to use in the method
            Int32 CustomerID = 5;
            Int32 ReviewID = 4;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            Look = AReview.Find(ReviewID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            Assert.IsTrue(Look);
        }
        
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            clsReview AReview = new clsReview();
            //boolean variable to find the result of the search
            Boolean Found = false;
            Boolean Look = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the methods
            Int32 CustomerID = 3;
            Int32 ReviewID = 9;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            Look =  AReview.Find(ReviewID);
            if (ACustomer.CustomerID != 3)
                {
                OK = false;
                }
            if (AReview.ReviewID != 9)
                {
                OK = false:
                }
            
            //test to see that the results are your desired outcome
            
            Assert.IsTrue(OK);

        }
        
        
