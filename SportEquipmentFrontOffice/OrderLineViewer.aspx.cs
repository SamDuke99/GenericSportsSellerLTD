using SportEquipmentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new Instance of clsOrder
        clsOrderLine AnOrderLine = new clsOrderLine();
        //Get the data from the session object
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        //Display the house # for this entry
        Response.Write(AnOrderLine.OrderNumber);
    }
}