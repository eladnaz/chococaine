﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace database
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
          

        }

        protected void Logoutclk(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }

}