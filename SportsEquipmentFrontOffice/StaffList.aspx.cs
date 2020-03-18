using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        SportEquipmentClasses.clsStaffCollection staffList = new SportEquipmentClasses.clsStaffCollection();
        lstStaff.DataSource = staffList.StaffList;
        lstStaff.DataValueField = "Id";
        lstStaff.DataTextField = "Fullname";
        lstStaff.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("Staff.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 staffId;

        if (lstStaff.SelectedIndex != -1)
        {
            staffId = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffId"] = staffId;
            Response.Redirect("DeleteStaff.aspx");
        } else
        {
            lblError.Text = "Please Select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 staffId = 0;

        if (lstStaff.SelectedIndex != -1)
        {
            staffId = Convert.ToInt32(lstStaff.SelectedValue);
            Session["StaffId"] = staffId;
            Response.Redirect("Staff.aspx");
        }
        else
        {
            lblError.Text = "Please Select a record to edit from the list";
        }
    }
}