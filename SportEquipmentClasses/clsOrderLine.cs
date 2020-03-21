using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEquipmentClasses
{
    public class clsOrderLine
    {
        private int mOrderLineNumber;
        public int OrderLineNumber
        {
            get
            {
                return mOrderLineNumber;
            }

            set
            {
                mOrderLineNumber = value;
            }
        }

        private int mOrderNumber;
        public int OrderNumber
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

        private int mProductID;
        public int ProductID
        {
            get
            {
                return mProductID;
            }

            set
            {
                mProductID = value;
            }
        }

        public bool Find(int OrderLineNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineNumber", OrderLineNumber);
            DB.Execute("sproc_tblOrder_FilterByOrderLineNumber");
            if (DB.Count == 1)
            {
                mOrderLineNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineNumber"]);
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string OrderNumber, string ProductID)
        {
            return "";
        }

    }
}
