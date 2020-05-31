﻿using System;

namespace SportEquipmentClasses
{
    public class ClsStock
    {
        private DateTime mDateAcquired;
        private string mProductDetails;
        private decimal mPrice;
        private bool mResult;
        private int mProductId;

        public int ProductId
        {
            get
            {
                return mProductId;
            }
            set
            {
                mProductId = value;
            }
        }
        public string ProductDetails
        {
            get
            {
                return mProductDetails;
            }
            set
            {
                mProductDetails = value;
            }
        }
        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public DateTime DateAcquired
        {
            get
            {
                return mDateAcquired;
            }
            set
            {
                mDateAcquired = value;
            }
        }
        public bool Result
        {
            get
            {
                return mResult;
            }
            set
            {
                mResult = value;
            }
        }
        public bool Find(int ProductId)
        {
            ClsDataConnection DB = new ClsDataConnection();
            DB.AddParameter("@ProductId", ProductId);
            DB.Execute("sproc_tblStock_FilterByProductID");
            if (DB.Count == 1)
            {
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mDateAcquired = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAcquired"]);
                mProductDetails = Convert.ToString(DB.DataTable.Rows[0]["ProductDetails"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                mResult = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                return true;
            }

            else
            {
                return false;
            }
        }
        public string Valid(string ProductDetails, string DateAcquired)
        {
            String Error = "";
            DateTime DateTemp;

            if (ProductDetails.Length == 0)
            {
                Error = Error + "The Product Details may not be blank: ";
            }
            if (ProductDetails.Length > 10)
            {
                Error = Error + "The Product Details must be less than 6 characters : ";
            }
            try
            {

                DateTemp = Convert.ToDateTime(DateAcquired);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date connot be in the past: ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date: ";
            }

            return Error;
        }
}
}