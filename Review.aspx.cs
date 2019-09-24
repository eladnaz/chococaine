using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace database
{
    public partial class Review : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ClearTextView()
        {
            Email.Text = "";
            Feedback.Text = "";
            Title1.Text = "";
        }

        protected void Submit_Click1(object sender, EventArgs e)
        {
            string title = Title1.Text;
            string email = Email.Text;
            string feedback = Feedback.Text;

            
            Output.Text = DatabasePull.DoInsert(title, email, feedback);
            ClearTextView();
            
        }
    }
}