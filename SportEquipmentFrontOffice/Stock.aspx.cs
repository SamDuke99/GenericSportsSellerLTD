using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class AnDetail : System.Web.UI.Page
{
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
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
        clsStockCollection stockList = new clsStockCollection();
        stockList.ThisProduct.Find(ProductId);
        txtProductID.Text = stockList.ThisProduct.ProductId.ToString();
        txtDetail.Text = stockList.ThisProduct.Detail.ToString();
        txtPrice.Text = stockList.ThisProduct.Price.ToString();
        txtPosition.Text = stockList.ThisProduct.Position.ToString();
        txtDateAcquired.Text = stockList.ThisProduct.DateAcquired.ToString();
        txtResult.Text = stockList.ThisProduct.Result.ToString();
    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();
        stock.ProductId = Convert.ToInt32( txtProductID.Text);
        stock.Detail = txtDetail.Text;
        stock.Price = txtPrice.Text;
        stock.DateAcquired = txtDateAcquired.Text;
        stock.Result = txtResult.Text;
        Session["stock"] = stock;
        Response.Write("AnDetail.aspx");

        if (stock.ValidProductId(ProductId) != "")
        {
            lblError.Text = stock.ValidProductId(ProductId);
            return;
        }

        if (stock.ValidDetail(Detail) != "")
        {
            lblDetail.Text = stock.ValidDetail(Detail);
            return;
        }

        if (stock.ValidPrice(price) != "")
        {
            lblPrice.Text = stock.ValidPrice(price);
            return;
        }

        if (stock.ValidDateAcquired(dateacquired) != "")
        {
            lblDateAcquired.Text = stock.ValidDateAcquired(dateacquired);
            return;
        }

        if (stock.ValidResult(result) != "")
        {
            lblResult.Text = stock.ValidResult(result);
            return;
        }

        stock.ProductId = Convert.ToInt32(ProductId);
        stock.DateAcquired = Convert.ToDateTime(DateAquired);
        stock.Detail = Detail;
        stock.Price = Price;
        stock.Result = Result;
        clsStockCollection stockList = new clsStockCollection();

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
}
    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();

        // Checks if the input is correct
        if (stock.ValidProductId(txtProductId.Text) != "")
        {
            lblError.Text = stock.ValidId(txtProductId.Text);
            txtDetail.Text = "";
            txtPrice.Text = "";
            txtDateAcquired.Text = "";
            chkResult.Checked = false;
            return;
        }

        Int32 staffId = Convert.ToInt32(txtProductId.Text);

        bool found = stock.Find(ProductId);
        if (found)
        {
            txtDetail.Text = stock.Detail;
            txtPrice.Text = stock.Price;
            txtDateAcquired.Text = Convert.ToString(stock.DateAcquired);
            chkResult.Checked = true;
        }
        else
        {
            txtDetail.Text = "";
            txtPrice.Text = "";
            txtDateAcquired.Text = "";
            chkResult.Checked = false;
            lblError.Text = "Record with provided ID does not exist";
        }
    }
}