using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class AnOrder : System.Web.UI.Page
{

    Int32 OrderNumber;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNumber = Convert.ToInt32(Session["OrderNumber"]);
        if (IsPostBack == false)
        {
            if (OrderNumber != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderNumber);

        txtOrderNumber.Text = OrderBook.ThisOrder.OrderNumber.ToString();
        txtOrderDescription.Text = OrderBook.ThisOrder.OrderDescription;
        txtOrderDatePlaced.Text = OrderBook.ThisOrder.OrderNumber.ToString();
        txtOrderCompleted.Text = OrderBook.ThisOrder.OrderNumber.ToString();
        txtOrderPrice.Text = OrderBook.ThisOrder.OrderNumber.ToString();
        txtOrderCustomerID.Text = OrderBook.ThisOrder.OrderNumber.ToString();
        txtOrderStaffID.Text = OrderBook.ThisOrder.OrderNumber.ToString();

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

            AnOrder.OrderNumber = OrderNumber;
            AnOrder.OrderDescription = OrderDescription;
            AnOrder.OrderDatePlaced = Convert.ToDateTime(OrderDatePlaced);
            AnOrder.OrderCompleted = Convert.ToBoolean(OrderCompleted);
            AnOrder.OrderPrice = (float)Convert.ToDouble(OrderPrice);
            AnOrder.CustomerID = Convert.ToInt32(CustomerID);
            AnOrder.StaffID = Convert.ToInt32(StaffID);

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderNumber == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderNumber);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
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
        //Create an instance of the Order class
        clsOrder AOrder = new clsOrder();
        //Variable to store the primary key
        Int32 OrderNumber;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //Get the primary key entered by the user
        OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
        //Find the record
        Found = AOrder.Find(OrderNumber);
        //If found
        if (Found == true)
        {
            //Display the values of the properties in the form
            AOrder.OrderDescription = txtOrderDescription.Text;
            AOrder.OrderDatePlaced = Convert.ToDateTime(txtOrderDatePlaced.Text);
            AOrder.OrderCompleted = Convert.ToBoolean(txtOrderCompleted.Text);
            AOrder.OrderPrice = Convert.ToSingle(txtOrderPrice.Text);
            AOrder.StaffID = Convert.ToInt32(txtOrderStaffID);
            AOrder.CustomerID = Convert.ToInt32(txtOrderCustomerID);
        }
    }
}