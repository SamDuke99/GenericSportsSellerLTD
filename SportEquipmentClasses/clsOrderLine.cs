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

        private int mProductQuantity;
        public int ProductQuantity
        {
            get
            {
                return mProductQuantity;
            }
            set
            {
                mProductQuantity = value;
            }
        }

        public bool Find(int OrderLineNumber)
        {
            //Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //Add the parameter for the OrderLine # to search for
            DB.AddParameter("@OrderLineNumber", OrderLineNumber);
            //Execute the stored procedure
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineNumber");
            //If 1 record is found (there should be either 1 or 0!)
            if (DB.Count == 1)
            {
                //Copy the data from the database to the private data members
                mOrderLineNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineNumber"]);
                mOrderNumber = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNumber"]);
                mProductID = Convert.ToInt32(DB.DataTable.Rows[0]["ProductID"]);
                mProductQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ProductQuantity"]);
                //Return that everything worked OK
                return true;
            }
            //If no record was found
            else
            {
                //Return false indicating a problem
                return false;
            }
        }

        public string Valid(string OrderNumber, string ProductID, string ProductQuantity)
        {
            string Error = "";

            if (OrderNumber.Length == 0)
            {
                Error = Error + "The Order Number may not be 0:  ";
            }
            if (OrderNumber.Length > 500)
            {
                Error = Error + "The Order Number must be less than 500 characters:  ";
            }

            return Error;
        }

    }
}
