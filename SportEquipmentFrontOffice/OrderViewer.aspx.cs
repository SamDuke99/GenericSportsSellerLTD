using SportEquipmentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Create a new Instance of clsOrder
        clsOrder AOrder = new clsOrder();
        //Get the data from the session object
        AOrder = (clsOrder)Session["AOrder"];
        //Display the house # for this entry
        Response.Write(AOrder.OrderDescription);
    }
}