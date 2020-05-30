using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsStock Stock = new ClsStock();
        Stock = (ClsStock)Session["Stock"];
        Response.Write(Stock.ProductId);
    }
}