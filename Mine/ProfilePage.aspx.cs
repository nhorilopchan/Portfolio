﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mine
{
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAspNetApplication_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("ASPNET.aspx", true);
        }
    }
}