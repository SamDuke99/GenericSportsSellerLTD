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
        ClsStock stock = new ClsStock
        {
            ProductId = Convert.ToInt32(txtProductId.Text),
            ProductDetails = txtProductDetails.Text,
            Price = Convert.ToDecimal(txtPrice.Text),
            DateAcquired = Convert.ToDateTime(txtDateAcquired.Text),
            Result = Convert.ToBoolean(txtInStock.Text)
        };
        Session["stock"] = stock;
        Response.Write("Stock.aspx");

        if (stock.ValidProductId(ProductId) != "")
        {
            lblError.Text = stock.ValidProductId(ProductId);
            return;
        }

        if (stock.ValidProductDetails(ProductDetails) != "")
        {
            lblProductDetails.Text = stock.ValidProductDetails(ProductDetails);
            return;
        }

        if (stock.ValidPrice(txtPrice) != "")
        {
            lblPrice.Text = stock.ValidPrice(txtPrice);
            return;
        }

        if (stock.ValidDateAcquired() != "")
        {
            lblDateAcquired.Text = stock.ValidDateAcquired();
            return;
        }

        if (stock.ValidInStock(txtInStock) != "")
        {
            lblInStock.Text = stock.ValidInStock(txtInStock);
            return;
        }

        stock.ProductId = Convert.ToInt32(ProductId);
        stock.DateAcquired = Convert.ToDateTime(DateAcquired);
        stock.ProductDetails = ProductDetails;
        stock.Price = Price;
        stock.Result = Result;
        ClsStockCollection stockList = new ClsStockCollection();

        if (ProductId == -1)
        {
            stockList.ThisProduct = stock;
            stockList.Add();
        }
        else
        {
            stockList.ThisProduct.Find(ProductId);
            stockList.ThisProduct = stock;
            stockList.Update();
        }

        Response.Redirect("StockList.aspx");

    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
    protected void BtnFind_Click(object sender, EventArgs e)
    {
        ClsStock stock = new ClsStock();

        // Checks if the input is correct
        if (stock.ValidProductId(txtProductId.Text) != "")
        {
            lblError.Text = stock.ValidProductId(txtProductId.Text);
            txtProductDetails.Text = "";
            txtPrice.Text = "";
            txtDateAcquired.Text = "";
            txtInStock.Text = "";
            return;
        }

        Int32 ProductId = Convert.ToInt32(txtProductId.Text);

        bool found = stock.Find(ProductId);
        if (found)
        {
            txtProductDetails.Text = stock.ProductDetails;
            txtPrice.Text = ""; 
            txtDateAcquired.Text = Convert.ToString(stock.DateAcquired);
            txtInStock.Text = "";
        }
        else
        {
            txtProductDetails.Text = "";
            txtPrice.Text = "";
            txtDateAcquired.Text = Convert.ToString(stock.DateAcquired);
            txtInStock.Text = "";
            lblError.Text = "Record with provided ID does not exist";
        }
    }
}