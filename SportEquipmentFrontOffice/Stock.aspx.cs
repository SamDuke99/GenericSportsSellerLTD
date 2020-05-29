using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class Stock : System.Web.UI.Page
{
    Int32 ProductId;

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if (ProductId != -1)
            {
                DisplayStock();
            }
        }
    }
    void DisplayStock()
    {
        ClsStockCollection stockList = new ClsStockCollection();
        stockList.ThisProduct.Find(ProductId);
        txtProductId.Text = stockList.ThisProduct.ProductId.ToString();
        txtProductDetails.Text = stockList.ThisProduct.ProductDetails.ToString();
        txtPrice.Text = stockList.ThisProduct.Price.ToString();
        txtDateAcquired.Text = stockList.ThisProduct.DateAcquired.ToString();
        txtInStock.Text = stockList.ThisProduct.Result.ToString();
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
        Session["stock"] = Stock;
        Response.Write("Stock.aspx");

        if (Stock.ValidProductId(ProductId) != "")
        {
            lblError.Text = Stock.ValidProductId(ProductId);
            return;
        }

    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void BtnFind_Click(object sender, EventArgs e)
    {
        ClsStock Stock = new ClsStock();
        Int32 ProductID;
        Boolean Found = false;
        ProductID = Convert.ToInt32(txtProductId.Text);
        Found = Stock.Find(ProductId);

        if (Found == true)
        {
            txtProductDetails.Text = Stock.ProductDetails;
            txtDateAcquired.Text = Stock.DateAcquired.ToString();
            txtPrice.Text = Stock.Price.ToString();
            txtInStock.Text = Stock.Result.ToString();
        }
    }
}