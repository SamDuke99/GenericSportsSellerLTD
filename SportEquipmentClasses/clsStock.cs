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
                mResult = Convert.ToBoolean(DB.DataTable.Rows[0]["Result"]);
                return true;
            }
            
            else
            {
                return false;
            }
        }

        

        public string ValidProductId(int ProductId)
        {
            string errorMsg = "";
            int value;
            try
            {
                value = Convert.ToInt32(ProductId);
            }
            catch (System.FormatException)
            {
                errorMsg = "ID must be a positive integer!";
                return errorMsg;
            }

            if (value < 0 || value > 256)
            {
                errorMsg = "ID must be a positive integer not greater than 256!";
            }

            return errorMsg;
        }
    }
}