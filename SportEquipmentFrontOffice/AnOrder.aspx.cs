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
        string OrderDescription = txtOrderDescription.Text;
        string OrderDatePlaced = txtOrderDatePlaced.Text;
        string OrderCompleted = txtOrderCompleted.Text;
        string OrderPrice = txtOrderPrice.Text;
        string CustomerID = txtOrderCustomerID.Text;
        string StaffID = txtOrderStaffID.Text;
        string Error = "";
        Error = AnOrder.Valid(OrderDescription, OrderDatePlaced, OrderCompleted,
            OrderPrice, CustomerID, StaffID);
        if (Error == "")
        {
            AnOrder.OrderDescription = OrderDescription;
            AnOrder.OrderDatePlaced = Convert.ToDateTime(OrderDatePlaced);
            AnOrder.OrderCompleted = Convert.ToBoolean(OrderCompleted);
            AnOrder.OrderPrice = (float)Convert.ToDouble(OrderPrice);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.StaffID = Convert.ToInt32(StaffID);

            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
            AOrder.OrderCompleted = Convert.ToBoolean(txtOrderCompleted.Text);
            AOrder.OrderPrice = Convert.ToSingle(txtOrderPrice.Text);
            AOrder.StaffID = Convert.ToInt32(txtOrderStaffID);
            AOrder.CustomerID = Convert.ToInt32(txtOrderCustomerID);
        }
    }
}