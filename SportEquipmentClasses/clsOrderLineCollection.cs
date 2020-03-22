using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEquipmentClasses
{
    public class clsOrderLineCollection
    {

        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();

        public List<clsOrderLine> OrderLineList
        {
            get
            {
                return mOrderLineList;
            }
            set
            {
                mOrderLineList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderLineList.Count;
            }
            set
            {

            }
        }

        public clsOrderLine ThisOrderLine
        {
            get
            {
                return mThisOrderLine;
            }
            set
            {
                mThisOrderLine = value;
            }
        }

        //constructor
        public clsOrderLineCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", mThisOrderLine.OrderNumber);
            DB.AddParameter("@ProductID", mThisOrderLine.ProductID);
            DB.AddParameter("@ProductQuantity", mThisOrderLine.ProductQuantity);

            return DB.Execute("sproc_tblOrderLine_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineNumber", mThisOrderLine.OrderLineNumber);
            DB.Execute("sproc_tblOrderLine_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineNumber", mThisOrderLine.OrderLineNumber);
            DB.AddParameter("@OrderNumber", mThisOrderLine.OrderNumber);
            DB.AddParameter("@ProductID", mThisOrderLine.ProductID);
            DB.AddParameter("@ProductQuantity", mThisOrderLine.ProductQuantity);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByOrderNumber(string OrderNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", OrderNumber);
            DB.Execute("sproc_tblOrderLine_FilterByOrderNumber");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            RecordCount = DB.Count;

            mOrderLineList = new List<clsOrderLine>();

            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.OrderLineNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineNumber"]);
                AnOrderLine.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
                AnOrderLine.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                AnOrderLine.ProductQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductQuantity"]);
                mOrderLineList.Add(AnOrderLine);
                Index++;
            }
        }
    }
}
