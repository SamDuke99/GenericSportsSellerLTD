using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class Stock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        ClsStock stock = new ClsStock();
        string ProductDetails = txtProductDetails.Text;
        string Price = txtPrice.Text;
        string DateAcquired = txtDateAcquired.Text;
        string InStock = txtInStock.Text;
        string Error = "";
        Error = stock.Valid(ProductDetails, DateAcquired);
        if (Error == "")
        {
            stock.ProductDetails = ProductDetails;
            stock.Price = Convert.ToDecimal(txtPrice.Text);
            stock.DateAcquired = Convert.ToDateTime(txtDateAcquired.Text);
            stock.Result = Convert.ToBoolean(txtInStock.Text);
            Session["Stock"] = stock;
            Response.Write("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
}