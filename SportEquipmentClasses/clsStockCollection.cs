using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportEquipmentClasses
{
    public class ClsStockCollection
    {
        List<ClsStock> stockList = new List<ClsStock>();
        ClsStock thisProduct = new ClsStock();
        public List<ClsStock> StockList { get { return stockList; } set { stockList = value; } }
        public ClsStock ThisProduct { get { return thisProduct; } set { thisProduct = value; } }

        public int Count { get { return stockList.Count; } set { } }

        public ClsStockCollection()
        {
            ClsDataConnection db = new ClsDataConnection();
            db.Execute("sproc_tblStock_Select_All");
            PopulateCollection(db);
        }

        public int Add()
        {
            ClsDataConnection db = new ClsDataConnection();
            db.AddParameter("@productid", thisProduct.ProductId);
            db.AddParameter("@detail", thisProduct.ProductDetails);
            db.AddParameter("@price", thisProduct.Price);
            db.AddParameter("@dateacquired", thisProduct.DateAcquired);
            db.AddParameter("@result", thisProduct.Result);
            return db.Execute("sproc_tblStock_Insert");
        }

        public void Delete()
        {
            ClsDataConnection db = new ClsDataConnection();
            db.AddParameter("@productid", thisProduct.ProductId);
            db.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            ClsDataConnection db = new ClsDataConnection();
            db.AddParameter("@productid", thisProduct.ProductId);
            db.AddParameter("@detail", thisProduct.ProductDetails);
            db.AddParameter("@price", thisProduct.Price);
            db.AddParameter("@dateacquired", thisProduct.DateAcquired);
            db.AddParameter("@result", thisProduct.Result);
            db.Execute("sproc_tblStock_Update");
        }

        void PopulateCollection(ClsDataConnection db)
        {
            Int32 index = 0;
            Int32 recordCount = 0;
            recordCount = db.Count;
            stockList = new List<ClsStock>();

            while (index < recordCount)
            {
                ClsStock stock = new ClsStock
                {
                    ProductId = Convert.ToInt32(db.DataTable.Rows[index]["ProductID"]),
                    DateAcquired = Convert.ToDateTime(db.DataTable.Rows[index]["DateAcquired"]),
                    ProductDetails = Convert.ToString(db.DataTable.Rows[index]["Detail"]),
                    Price = Convert.ToDecimal(db.DataTable.Rows[index]["Price"]),
                    Result = Convert.ToBoolean(db.DataTable.Rows[index]["Result"])
                };
                index++;
                stockList.Add(stock);
            }
        }
    }
}
