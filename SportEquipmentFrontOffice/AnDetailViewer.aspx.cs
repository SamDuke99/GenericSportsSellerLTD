﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SportEquipmentClasses;

public partial class AnDetailViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AnDetial = new clsStock();
        AnDetail = (clsStock)Session["AnDetail"];
        Response.Write(AnDetail.ProductID);
    }
}