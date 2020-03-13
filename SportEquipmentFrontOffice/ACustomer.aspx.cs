using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the Username
        ACustomer.UserName = txtUsername.Text;
        //capture the password
        ACustomer.Password = txtPassword.Text;
        //capture the email
        ACustomer.Email = txtEmail.Text;
        //capture the Date of Birth
        ACustomer.DateOfBirth = Convert.ToDateTime(txtDOB.Text);
        //store the Customer in the session object
        Session["ACustomer"] = ACustomer;
        //redirect to the viewer page
        Response.Redirect("ACustomerViewer.aspx");


    }
}