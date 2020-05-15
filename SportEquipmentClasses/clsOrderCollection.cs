using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEquipmentClasses
{
    public class clsOrderCollection
    {

        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }
   
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public clsOrderLine ThisOrderLine { get; set; }

        //constructor
        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderDescription", mThisOrder.OrderDescription);
            DB.AddParameter("@OrderDatePlaced", mThisOrder.OrderDatePlaced);
            DB.AddParameter("@OrderCompleted", mThisOrder.OrderCompleted);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNumber", mThisOrder.OrderNumber);
            DB.AddParameter("@OrderDescriptionr", mThisOrder.OrderDescription);
            DB.AddParameter("@OrderDatePlaced", mThisOrder.OrderDatePlaced);
            DB.AddParameter("@OrderCompleted", mThisOrder.OrderCompleted);
            DB.AddParameter("@OrderPrice", mThisOrder.OrderPrice);
            DB.AddParameter("@CustomerID", mThisOrder.CustomerID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByOrderDescription(string OrderDescription)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderDescription", OrderDescription);
            DB.Execute("sproc_tblOrder_FilterByOrderDescription");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            RecordCount = DB.Count;

            mOrderList = new List<clsOrder>();

            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNumber"]);
                AnOrder.OrderDescription = Convert.ToString(DB.DataTable.Rows[Index]["OrderDescription"]);
                AnOrder.OrderDatePlaced = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderDatePlaced"]);
                AnOrder.OrderCompleted = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderCompleted"]);
                AnOrder.OrderPrice = (float)Convert.ToDecimal(DB.DataTable.Rows[Index]["OrderPrice"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        
        }
    }
}
