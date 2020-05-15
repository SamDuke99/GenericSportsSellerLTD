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
        string ProductQuantity = txtProductQuantity.Text;

        string Error = "";
        Error = AnOrderLine.Valid(OrderNumber, ProductID, ProductQuantity);
        if (Error == "")
        {

            AnOrderLine.OrderLineNumber = OrderLineNumber;
            AnOrderLine.OrderNumber = Convert.ToInt32(OrderNumber);
            AnOrderLine.ProductID = Convert.ToInt32(ProductID);
            AnOrderLine.ProductQuantity = Convert.ToInt32(ProductQuantity);

            clsOrderCollection OrderLineList = new clsOrderCollection();

            if (OrderLineNumber == -1)
            {
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Add();
            }
            else
            {
                OrderLineList.ThisOrderLine.Find(OrderLineNumber);
                OrderLineList.ThisOrderLine = AnOrderLine;
                OrderLineList.Update();
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
        //Create an instance of the Order class
        clsOrderLine AnOrderLine = new clsOrderLine();
        //Variable to store the primary key
        Int32 OrderLineNumber;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //Get the primary key entered by the user
        OrderLineNumber = Convert.ToInt32(txtOrderLineNumber.Text);
        //Find the record
        Found = AnOrderLine.Find(OrderLineNumber);
        //If found
        if (Found == true)
        {
            //Display the values of the properties in the form
            AnOrderLine.OrderNumber = Convert.ToInt32(txtOrderNumber.Text);
            AnOrderLine.ProductID = Convert.ToInt32(txtProductID.Text);
            AnOrderLine.ProductQuantity = Convert.ToInt32(txtProductQuantity.Text);
        }
    }
}