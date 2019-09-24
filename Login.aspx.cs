using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace database
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            DatabasePull.GetCredentials(username, password);
            if (DatabasePull.GetCredentials(username, password) == true)
            {
                LabelOutput.Text = "Login successful";
                Response.Redirect("Admin.aspx");
            }

            else
            {
                LabelOutput.Text = "Wrong Username or Password , Try Again";
                Username.Text = "";
                Password.Text = "";
            }
        }
    }
}

