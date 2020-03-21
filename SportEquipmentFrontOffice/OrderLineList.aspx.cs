using SportEquipmentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrderLines();
        }
    }

    void DisplayOrderLines()
    {
        clsOrderLineCollection Orders = new clsOrderLineCollection();
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineNumber";
        lstOrderLineList.DataTextField = "OrderNumber";
        lstOrderLineList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderLineNumber"] = -1;
        Response.Redirect("AnOrderLine.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderLineNumber;

        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineNumber = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineNumber"] = OrderLineNumber;
            Response.Redirect("DeleteOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderLineNumber;

        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineNumber = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineNumber"] = OrderLineNumber;
            Response.Redirect("AnOrderLine.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        OrderLines.ReportByOrderLineNumber(txtOrderLineNumber.Text);
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineNumber";
        lstOrderLineList.DataTextField = "OrderNumber";
        lstOrderLineList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        OrderLines.ReportByOrderNumber("");
        txtOrderNumber.Text = "";
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineNumber";
        lstOrderLineList.DataTextField = "OrderNumber";
        lstOrderLineList.DataBind();

    }
}