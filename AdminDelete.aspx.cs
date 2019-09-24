using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;

namespace database
{
    public partial class AdminDelete : System.Web.UI.Page
    {
        string ChocChoice;
        string Id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }
        private void FillPage()
        {
            ArrayList chocList = DatabasePull.GetDetails(Id);
            StringBuilder table = new StringBuilder();

            foreach (Choco choco in chocList)
            {
                table.Append(string.Format(
                    @"<table class='chocTable'>
                    <tr>
                        <th rowspan='5' width = '25px'> ID </th>
                        <th rowspan ='5' width = '25px'>{0}</th>
                        <th rowspan='5' width = '250px'><img runat='server' src='{5}' height ='200px' width ='200px'/></th>
                        <th width='50px' height='20px'>Name: </td>
                        <td height='25px'>{2}</td>
                    </tr>
                    <tr>
                        <th height='25px'>Brand:</th>
                        <td height='25px'>{1}</td>
                    </tr>
                    <tr>
                        <th height='25px'>Price:</th>
                        <td height='25px'> RM{3}</td>
                    </tr>
                    <tr>
                        <td colspan='3' width='500px'>{4}</td>
                    </tr>
                    </table>"
                    , choco.Id, choco.brand, choco.name, choco.price, choco.desc, choco.img));

                LabelOutput.Text = table.ToString();


            }
        }

        public void ClearTextView()
        {
            Selection.Text = "";
            
        }

        protected void Filter_Click(object sender, EventArgs e)
        {
            ChocChoice = ChocFilter.SelectedValue;
            if (ChocChoice == "Milk Chocolate")
            {
                Id = "Milk";
                FillPage();
            }
            else if (ChocChoice == "Dark Chocolate")
            {
                Id = "Dark";
                FillPage();
            }
            else if (ChocChoice == "Liquor Chocolate")
            {
                Id = "Liquor";
                FillPage();
            }
            else if (ChocChoice == "White Chocolate")
            {
                Id = "White";
                FillPage();
            }
            else
            {
                Id = "";
                FillPage();
            }

        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            string id = Selection.Text;
            DeleteOutput.Text = DatabasePull.DeleteChoc(id);
            FillPage();
            ClearTextView();

        }
    }
}