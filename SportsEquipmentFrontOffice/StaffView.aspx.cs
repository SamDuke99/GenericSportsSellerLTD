using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class StaffView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff staffMember = new clsStaff();
        staffMember = (clsStaff)Session["AddStaff"];
        Response.Write(staffMember.Fullname);
    }
}