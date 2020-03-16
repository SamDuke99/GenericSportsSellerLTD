using System;

namespace SportEquipmentClasses
{
    public class clsOrder
    {
        private DateTime mOrderDatePlaced;
        public DateTime OrderDatePlaced
        {
            get
            {
                return mOrderDatePlaced;
            }
            set
            {
                mOrderDatePlaced = value;
            }
        }

        private Int32 mOrderNumber;
        public Int32 OrderNumber
        {
            get
            {
                return mOrderNumber;
            }
            set
            {
                mOrderNumber = value;
            }
        }

        private String mOrderDescription;
        public string OrderDescription
        {
            get
            {
                return mOrderDescription;
            }
            set
            {
                mOrderDescription = value;
            }
        }

        private Boolean mOrderCompleted;
        public bool OrderCompleted
        {
            get
            {
                return mOrderCompleted;
            }
            set
            {
                mOrderCompleted = value;
            }
        }

        private float mOrderPrice;
        public float OrderPrice
        {
            get
            {
                return mOrderPrice;
            }
            set
            {
                mOrderPrice = value;
            }
        }

        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
        }

        private Int32 mStaffID;
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        public bool Find(int OrderNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", OrderNumber);
            DB.Execute("sproc_tblOrder_FilterByOrderNumber");
            if (DB.Count == 1)
            {
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mOrderDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDescription"]);
                mOrderDatePlaced = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDatePlaced"]);
                mOrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderCompleted"]);
                mOrderPrice = Convert.ToInt32(DB.DataTable.Rows[0]["OrderPrice"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string orderDescription, 
            string orderDatePlaced,
            string orderCompleted,
            string orderPrice,
            string orderCustomerID,
            string orderStaffID)
        {
            return "";
        }
    }
}