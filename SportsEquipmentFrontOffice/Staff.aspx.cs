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

    private void Reset_All()
    {
        lblError.Text = "";
        lblFullname.Text = "";
        lblHireDate.Text = "";
        lblDepartment.Text = "";
        lblPassword.Text = "";
        lblPosition.Text = "";
    }

    protected void btnOK_click(object sender, EventArgs e)
    {
        Reset_All();
        clsStaff staffMember = new clsStaff();
        string id = txtStaffId.Text;
        string password = txtPassword.Text;
        string fullname = txtFullname.Text;
        string position = txtPosition.Text;
        string department = txtDepartment.Text;
        string hireDate = txtHireDate.Text;

        if (staffMember.ValidId(id) != "") {
            lblError.Text = staffMember.ValidId(id);
            return;
        }

        if (staffMember.ValidFullname(fullname) != "")
        {
            lblFullname.Text = staffMember.ValidFullname(fullname);
            return;
        }

        if (staffMember.ValidPosition(position) != "")
        {
            lblPosition.Text = staffMember.ValidPosition(position);
            return;
        }

        if (staffMember.ValidDepartment(department) != "")
        {
            lblDepartment.Text = staffMember.ValidDepartment(department);
            return;
        }

        if (staffMember.ValidPassword(password) != "")
        {
            lblPassword.Text = staffMember.ValidPassword(password);
            return;
        }

        if (staffMember.ValidHireDate(hireDate) != "")
        {
            lblHireDate.Text = staffMember.ValidHireDate(hireDate);
            return;
        }

        staffMember.Id = Convert.ToInt32(id);
        staffMember.HireDate = Convert.ToDateTime(hireDate);
        staffMember.Password = password;
        staffMember.Position = position;
        staffMember.Department = department;
        staffMember.Fullname = fullname;
        staffMember.IsActive = chkActive.Checked;

    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        Reset_All();
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