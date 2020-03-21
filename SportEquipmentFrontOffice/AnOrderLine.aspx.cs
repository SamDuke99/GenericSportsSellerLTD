using SportEquipmentClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrderLine : System.Web.UI.Page
{
    Int32 OrderLineNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineNumber = Convert.ToInt32(Session["OrderLineNumber"]);
        if (IsPostBack == false)
        {
            if (OrderLineNumber != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrderLineCollection OrderLineBook = new clsOrderLineCollection();
        OrderLineBook.ThisOrderLine.Find(OrderLineNumber);

        txtOrderLineNumber.Text = OrderLineBook.ThisOrderLine.OrderLineNumber.ToString();
        txtOrderNumber.Text = OrderLineBook.ThisOrderLine.OrderNumber.ToString();
        txtProductID.Text = OrderLineBook.ThisOrderLine.ProductID.ToString();
    }

    protected void btnOrderLineSubmit_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        string OrderNumber = txtOrderNumber.Text;
        string ProductID = txtProductID.Text;

        string Error = "";
        Error = AnOrderLine.Valid(OrderNumber, ProductID);
        if (Error == "")
        {

            AnOrderLine.OrderLineNumber = OrderLineNumber;
            AnOrderLine.OrderNumber = Convert.ToInt32(OrderNumber);
            AnOrderLine.ProductID = Convert.ToInt32(ProductID);

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderLineNumber == -1)
            {
                OrderList.ThisOrder = AnOrderLine;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderLineNumber);
                OrderList.ThisOrder = AnOrderLine;
                OrderList.Update();
            }
        }
        else
        {
            lblOrderLineError.Text = Error;
        }
    }

    protected void btnOrderLineCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnOrderLineFind_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        Int32 OrderLineNumber;
        Boolean Found = false;

        OrderLineNumber = Convert.ToInt32(txtOrderLineNumber.Text);
        Found = AnOrderLine.Find(OrderLineNumber);
        if (Found == true)
        {
            AnOrderLine.OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
            AnOrderLine.ProductID = Convert.ToInt32(txtProductID.Text);

        }
    }
}