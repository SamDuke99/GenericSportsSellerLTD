using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class AnDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsStock AnDetail = new clsStock();
        AnDetail.ProductId = Convert.ToInt32( txtProductID.Text);
        AnDetail.Gender = txtGender.Text;
        AnDetail.Size = txtSize.Text;
        AnDetail.Colour = txtColour.Text;
        AnDetail.Brand = txtBrand.Text;
        Session["AnDetail"] = AnDetail;
        Response.Write("DetailViewer.aspx");
    }
    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
}