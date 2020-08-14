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
            clsReview Review = new clsReview();
            Assert.IsNotNull(Review);

        }

        [TestMethod]
        public void ReviewTrustedPropertyOk()
        {
            clsReview Review = new clsReview();
            Boolean TestData = true;
            Review.ReviewTrusted = TestData;
            Assert.AreEqual(Review.ReviewTrusted, TestData);

        }

        [TestMethod]
        public void ReviewDatePostedPropertyOK()
            
        {
            clsReview Review = new clsReview();
            DateTime TestData = DateTime.Now.Date;
            Review.ReviewDatePosted = TestData;
            Assert.AreEqual(Review.ReviewDatePosted, TestData);
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
            clsReview Review = new clsReview();
            
            //create some test data to assign to the property
            Int32 TestData = 4;
            
            //assign the data to the property
            Review.ReviewID = TestData;
            
            //test to see that the two values are the same
            Assert.AreEqual(Review.ReviewID, TestData);
        }
        
        [TestMethod]
        public void ReviewContentOK()
        {
            //create an instance of the class we want to create
            clsReview Review = new clsReview();
            
            //create some test data to assign to the property
            string TestData = "Twas great";
            
            //assign the data to the property
            Review.ReviewContent = TestData;
            
            //test to see that the two values are the same
            Assert.AreEqual(Review.ReviewContent, TestData);
        }
        
        [TestMethod]
        public void ReviewRatingOK()
            
        {
            clsReview Review = new clsReview();
            Decimal TestData = 5.0;
            Review.ReviewRating = TestData;
            Assert.AreEqual(Review.ReviewRating, TestData);
        }
        
        [TestMethod]
        public void FindMethodOK()
            
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            clsReview Review = new clsReview();
            //boolean to store the result of the validation 
            Boolean Found = false;
            Boolean Look = false;
            //create some test data to use in the method
            Int32 CustomerID = 5;
            Int32 ReviewID = 4;
            //invoke the method
            Found = ACustomer.Find(CustomerID);
            Look = Review.Find(ReviewID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
            Assert.IsTrue(Look);
        }
        
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            clsReview Review = new clsReview();
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
            Look =  Review.Find(ReviewID);
            if (ACustomer.CustomerID != 3)
                {
                OK = false;
                }
            if (Review.ReviewID != 9)
                {
                OK = false:
                }
            
            //test to see that the results are your desired outcome
            
            Assert.IsTrue(OK);

        }
        
        
