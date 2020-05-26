using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class DeleteStock : System.Web.UI.Page
{
    Int32 ProductId;

    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
    }
    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection stockList = new clsStockCollection();
        stockList.ThisProduct.Find(ProductId);
        stockList.Delete();
        Response.Redirect("AnDetailList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnDetailList.aspx");
    }
}