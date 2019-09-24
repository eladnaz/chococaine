using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Text;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;
using System.IO;

namespace database
{
    public partial class AdminEdit : System.Web.UI.Page
    {
        string Id;
        string ChocChoice;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDetails(Id);
            }
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


        protected void Pull_Click(object sender, EventArgs e)
        {
            string Id = Selection.Text;
            LoadDetails(Id);


        }

        public void LoadDetails(string Id)
        {
            string openConnection = WebConfigurationManager.ConnectionStrings["ChococaineConnectionString1"].ConnectionString;
            SqlConnection con = new SqlConnection(openConnection);
            con.Open();
            SqlDataReader myReader = null;
            string sql = string.Format("SELECT * FROM Inventory1 WHERE Id LIKE '{0}'", Id);
            SqlCommand text = new SqlCommand("", con);
            text.CommandText = sql;
            myReader = text.ExecuteReader();

            while (myReader.Read())
            {
                Brand.Text = (myReader["brand"].ToString());
                Name.Text = (myReader["name"].ToString());
                Type.SelectedValue = (myReader["type"].ToString());
                Price.Text = (myReader["price"].ToString());
                Desc.Text = (myReader["description"].ToString());
                ImageText.Text = (myReader["image"].ToString());
            }
            con.Close();
        }

        public void ClearTextView()
        {
            Selection.Text = "";
            Brand.Text = "";
            Name.Text = "";
            Desc.Text = "";
            ImageText.Text = "";
            Price.Text = "";
        }


        protected void Save_Click(object sender, EventArgs e)
        {
            string Id = Selection.Text;
            string brand = Brand.Text;
            string name = Name.Text;
            string type = Type.SelectedValue;
            SqlDecimal price = SqlDecimal.Parse(Price.Text);
            string desc = Desc.Text;

            string file = Path.GetFileName(Image.FileName);
            string img = "Images/" + file;

            if (img == ImageText.Text || file == "")
            {
                img = ImageText.Text;
            }
            else
            {
                Image.SaveAs(Server.MapPath("~/Images/") + file);
            }

            Choco choco = new Choco(brand, name, type, price, desc, img);
            DatabasePull.EditChoco(choco, Id);
            FillPage();
            ClearTextView();
            update.Text = "Updated Sucessfully";
        }

        protected void Brand_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ChocFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}