using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlTypes;
using System.Collections;
using System.Text;

namespace database
{
    public partial class AdminAdd : System.Web.UI.Page
    {

        string Id;
        string ChocChoice;

        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void ClearTextField()
        {
            Name.Text = "";
            Price.Text = "";
            Desc.Text = "";
            Brand.Text = "";
        }



        protected void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string file = Path.GetFileName(Upload.FileName);
                Upload.SaveAs(Server.MapPath("~/Images/") + file);


                string brand = Brand.Text;
                string name = Name.Text;
                string type = Type.SelectedValue;
                SqlDecimal price = SqlDecimal.Parse(Price.Text);
                string desc = Desc.Text;
                string image = "Images/" + file;

                Choco choco = new Choco(brand, name, type, price, desc, image);

                DatabasePull.AddChoco(choco);
                FillPage();
                Result.Text = "Upload Success";
                ClearTextField();
            }


            catch (Exception)
            {
                Result.Text = "Upload Failed!";
            }
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
    }
}

