using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class AnDetail : System.Web.UI.Page
{
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            if (ProductId != -1)
            {
                DisplayStaff();
            }
        }
    }
    void DisplayStock()
    {
        clsStockCollection stockList = new clsStockCollection();
        stockList.ThisProduct.Find(ProductId);
        txtProductID.Text = stockList.ThisProduct.ProductId.ToString();
        txtDetail.Text = stockList.ThisProduct.Detail.ToString();
        txtPrice.Text = stockList.ThisProduct.Price.ToString();
        txtPosition.Text = stockList.ThisProduct.Position.ToString();
        txtDateAcquired.Text = stockList.ThisProduct.DateAcquired.ToString();
        chkResult.Checked = stockList.ThisProduct.Result;
    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsStock stock = new clsStock();
        stock.ProductId = Convert.ToInt32( txtProductID.Text);
        stock.Gender = txtGender.Text;
        stock.Size = txtSize.Text;
        stock.Colour = txtColour.Text;
        stock.Brand = txtBrand.Text;
        Session["stock"] = stock;
        Response.Write("AnDetail.aspx");

        if (stock.ValidProductId(ProductId) != "")
        {
            lblError.Text = stock.ValidProductId(ProductId);
            return;
        }

        if (stock.ValidGender(Gender) != "")
        {
            lblGender.Text = stock.ValidGender(Gender);
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
        clsStaffCollection staffList = new clsStaffCollection();

        if (staffId == -1)
        {
            staffList.ThisStaffMember = staffMember;
            staffList.Add();
        }
        else
        {
            staffList.ThisStaffMember.Find(staffId);
            staffList.ThisStaffMember = staffMember;
            staffList.Update();
        }

        Response.Redirect("StaffList.aspx");

    }
}
    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
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