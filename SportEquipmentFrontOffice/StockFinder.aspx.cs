using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class StockFinder : System.Web.UI.Page
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
    protected void BtnFind_Click(object sender, EventArgs e)
    {
        ClsStock Stock = new ClsStock();
        int ProductId;
        bool Found = false;
        ProductId = Convert.ToInt32(txtProductId.Text);
        Found = Stock.Find(ProductId);


        if (Found == true)
        {
            txtProductDetails.Text = Stock.ProductDetails;
            txtDateAcquired.Text = Stock.DateAcquired.ToString();
            txtPrice.Text = Stock.Price.ToString();
            txtInStock.Text = Stock.Result.ToString();
        }
        else
        {
            txtProductDetails.Text = "";
            txtDateAcquired.Text = "";
            txtPrice.Text = "";
            txtInStock.Text = "";
            lblError.Text = "Provided ProductID does not exist. Please enter a valid ProductID!";
        }
    }
}