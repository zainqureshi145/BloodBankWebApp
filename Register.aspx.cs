using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User UO = new User();

            Response.Write("Registration Successful!");
            UO.UserName = UN.Text;
            UO.Email = Email.Text;
            UO.Pass = Pass.Text;

            //Server.Transfer("BloodBank.aspx", true);
        }
    }
}