﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Login Successful!");
            Server.Transfer("BloodBank.aspx", true);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("Register.aspx", true);
        }
    }
}