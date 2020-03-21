using SportEquipmentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNumber";
        lstOrderList.DataTextField = "OrderDescription";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderNumber"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderNumber;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNumber"] = OrderNumber;
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNumber;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderNumber = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderNumber"] = OrderNumber;
            Response.Redirect("AnOrder.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderDescription(txtOrderDescription.Text);
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNumber";
        lstOrderList.DataTextField = "OrderDescription";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByOrderDescription("");
        txtOrderDescription.Text = "";
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNumber";
        lstOrderList.DataTextField = "OrderDescription";
        lstOrderList.DataBind();
    }
}