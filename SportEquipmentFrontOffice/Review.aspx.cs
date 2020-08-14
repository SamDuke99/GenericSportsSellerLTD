using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class Review : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsReview review = new clsReview();
        string ReviewContent = txtReviewContent.Text;
        string ReviewDatePosted = txtReviewDatePosted.Text;
        string ReviewRating = txtReviewRating.Text;
        string ReviewTrusted = txtReviewTrusted.Text;
        string Error = "";
        Error = review.Valid(ReviewContent, ReviewDatePosted);
        if (Error == "")
        {
            review.ReviewContent = ReviewContent
            review.ReviewRating = Convert.ToDecimal(txtReviewRating.Text);
            review.ReviewDatePosted = Convert.ToDateTime(txtReviewDatePosted.Text);
            review.ReviewTrusted = Convert.ToBoolean(txtReviewTrusted.Text);
            Session["Review"] = review;
            Response.Write("ReviewViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {

    }
}
