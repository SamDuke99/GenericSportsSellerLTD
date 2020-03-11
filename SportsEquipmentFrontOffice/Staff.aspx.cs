using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class AddStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            
    }

    protected void btnOK_click(object sender, EventArgs e)
    {
        clsStaff staffMember = new clsStaff();
        staffMember.Id = Convert.ToInt32(txtStaffId.Text);
        staffMember.Fullname = txtFullname.Text;
        staffMember.Position = txtPosition.Text;
        staffMember.Department = txtDepartment.Text;
        staffMember.Password = txtPassword.Text;
        staffMember.HireDate = Convert.ToDateTime(txtHireDate.Text); // todo catch exception
        Session["AddStaff"] = staffMember;
        Response.Redirect("StaffView.aspx");
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        lblError.Text = "";
        clsStaff staffMember = new clsStaff();
        
        // Checks if the input is correct
        if (staffMember.ValidId(txtStaffId.Text) != "")
        {
            lblError.Text = staffMember.ValidId(txtStaffId.Text);
            txtFullname.Text = "";
            txtPassword.Text = "";
            txtHireDate.Text = "";
            txtPosition.Text = "";
            txtDepartment.Text = "";
            chkActive.Checked = false;
            return;
        }

        Int32 staffId = Convert.ToInt32(txtStaffId.Text);
        
        bool found = staffMember.Find(staffId);
        if (found)
        {
            txtFullname.Text = staffMember.Fullname;
            txtPassword.Text = staffMember.Password;
            txtHireDate.Text = Convert.ToString(staffMember.HireDate);
            txtPosition.Text = staffMember.Position;
            txtDepartment.Text = staffMember.Department;
            chkActive.Checked = true;
        }
        else
        {
            txtFullname.Text = "";
            txtPassword.Text = "";
            txtHireDate.Text = "";
            txtPosition.Text = "";
            txtDepartment.Text = "";
            chkActive.Checked = false;
            lblError.Text = "Record with provided ID does not exist";
        }
    }
}