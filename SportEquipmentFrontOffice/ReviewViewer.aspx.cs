using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class ReviewViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsReview Review = new clsReview();
        Review = (clsReview)Session["Review"];
        Response.Write(Review.ReviewID);
    }
}
