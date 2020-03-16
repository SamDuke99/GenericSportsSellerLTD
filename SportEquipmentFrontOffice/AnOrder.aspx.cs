using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    
    protected void btnOrderSubmit_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        //OrderNumber
        AnOrder.OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        //OrderDescription
        AnOrder.OrderDescription = txtOrderDescription.Text;
        //OrderDatePlaced
        AnOrder.OrderDatePlaced = Convert.ToDateTime(txtOrderDatePlaced.Text);
        //OrderCompleted
        AnOrder.OrderCompleted = Convert.ToBoolean(checkOrderCompleted);
        //OrderPrice
        AnOrder.OrderPrice = Convert.ToInt32(txtOrderPrice.Text);
        //OrderCustomerID
        AnOrder.CustomerID = Convert.ToInt32(txtOrderCustomerID.Text);
        //OrderStaffID
        AnOrder.StaffID = Convert.ToInt32(txtOrderStaffID.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnOrderCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOrderNumberFind_Click(object sender, EventArgs e)
    {
        clsOrder AOrder = new clsOrder();
        Int32 OrderNumber;
        Boolean Found = false;
        OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        Found = AOrder.Find(OrderNumber);
        if (Found == true)
        {
            AOrder.OrderDescription = txtOrderDescription.Text;
            AOrder.OrderDatePlaced = Convert.ToDateTime(txtOrderDatePlaced.Text);
            AOrder.OrderCompleted = Convert.ToBoolean(checkOrderCompleted.Checked);
            AOrder.OrderPrice = Convert.ToSingle(txtOrderPrice.Text);
            AOrder.StaffID = Convert.ToInt32(txtOrderStaffID);
            AOrder.CustomerID = Convert.ToInt32(txtOrderCustomerID);
        }
    }
}