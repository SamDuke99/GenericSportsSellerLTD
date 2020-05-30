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
        ClsStock Stock = new ClsStock
        {
            ProductId = Convert.ToInt32(txtProductId.Text),
            ProductDetails = txtProductDetails.Text,
            Price = Convert.ToDecimal(txtPrice.Text),
            DateAcquired = Convert.ToDateTime(txtDateAcquired.Text),
            Result = Convert.ToBoolean(txtInStock.Text)
        };
        Session["Stock"] = Stock;
        Response.Write("StockViewer.aspx");

    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
}