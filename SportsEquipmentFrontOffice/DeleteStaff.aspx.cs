using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class DeleteStaff : System.Web.UI.Page
{
    Int32 staffId;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffId = Convert.ToInt32(Session["StaffId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStaffCollection staffList = new clsStaffCollection();
        staffList.ThisStaffMember.Find(staffId);
        staffList.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}