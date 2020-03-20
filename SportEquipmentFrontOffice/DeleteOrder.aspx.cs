using SportEquipmentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrder : System.Web.UI.Page
{

    Int32 OrderNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderNumber);
        OrderBook.Delete();
        Response.Redirect("OrderList.aspx");
    }
}