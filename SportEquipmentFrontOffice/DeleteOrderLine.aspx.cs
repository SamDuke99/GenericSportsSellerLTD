using SportEquipmentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrderLine : System.Web.UI.Page
{
    Int32 OrderLineNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineNumber = Convert.ToInt32(Session["OrderLineNumber"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLineBook = new clsOrderLineCollection();
        OrderLineBook.ThisOrderLine.Find(OrderLineNumber);
        OrderLineBook.Delete();
        Response.Redirect("OrderLineList.aspx");
    }
}