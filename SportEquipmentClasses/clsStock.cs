using System;

namespace SportEquipmentClasses
{
    public class clsStock
    {
        private DateTime mDateAcquired;
        private string mDetail;
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
        public string Detail
        {
            get
            {
                return mDetail;
            }
            set
            {
                mDetail = value;
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
        public bool Find(int ProductNo)
        {
            mProductId = 1;
            mDateAcquired = Convert.ToDateTime("16/9/2015");
            mDetail = "21";
            mPrice = 9.99M;
            mResult = true;
            return true;
        }
        public string Gender { get; set; }
        public string Size { get; set; }
        public string Colour { get; set; }
        public string Brand { get; set; }
        
    }
}