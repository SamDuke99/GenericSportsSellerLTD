using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEquipmentClasses
{
    public class clsStockCollection
    {
        List<clsStock> stockList = new List<clsStock>();
        clsStock thisProduct = new clsStock();
        public List<clsStock> StockList { get { return stockList; } set { stockList = value; } }
        public clsStock ThisProduct { get { return thisProduct; } set { thisProduct = value; } }

        public int Count { get { return stockList.Count; } set { } }

        public clsStockCollection()
        {
            clsDataConnection db = new clsDataConnection();
            db.Execute("sproc_tblStock_Select_All");
            populateCollection(db);
        }

        public int Add()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@productid", thisProduct.ProductId);
            db.AddParameter("@detail", thisProduct.Detail);
            db.AddParameter("@price", thisProduct.Price);
            db.AddParameter("@dateacquired", thisProduct.DateAcquired);
            db.AddParameter("@result", thisProduct.Result);
            return db.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@productid", thisProduct.ProductId);
            db.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@productid", thisProduct.ProductId);
            db.AddParameter("@detail", thisProduct.Detail);
            db.AddParameter("@price", thisProduct.Price);
            db.AddParameter("@dateacquired", thisProduct.DateAcquired);
            db.AddParameter("@result", thisProduct.Result);
            db.Execute("sproc_tblStock_Update");
        }

        public void ReportByPosition(string pos)
        {
            clsDataConnection db = new clsDataConnection();
            db.AddParameter("@position", pos);
            db.Execute("sproc_tblStock_FilterByPosition");
            populateCollection(db);
        }

        void populateCollection(clsDataConnection db)
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            recordCount = db.Count;
            stockList = new List<clsStock>();

            while (index < recordCount)
            {
                clsStock stock = new clsStock();
                stock.ProductId = Convert.ToInt32(db.DataTable.Rows[index]["ProductID"]);
                stock.DateAcquired = Convert.ToDateTime(db.DataTable.Rows[index]["DateAcquired"]);
                stock.Detail = Convert.ToString(db.DataTable.Rows[index]["Detail"]);
                stock.Price = Convert.ToDecimal(db.DataTable.Rows[index]["Price"]);
                stock.Result = Convert.ToBoolean(db.DataTable.Rows[index]["Result"]);
                index++;
                stockList.Add(stock);
            }
        }
    }
}
