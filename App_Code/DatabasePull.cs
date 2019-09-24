using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Collections;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace database
{
    public static class DatabasePull
    {
        private static SqlConnection con;
        private static SqlCommand text;

        static DatabasePull()
        {
            string openConnection = WebConfigurationManager.ConnectionStrings["ChococaineConnectionString1"].ConnectionString;
            con = new SqlConnection(openConnection);
            text = new SqlCommand("", con);
        }

        public static ArrayList GetDetails(string type)
        {
            ArrayList Details = new ArrayList();
            string sql = string.Format("SELECT * FROM Inventory1 WHERE Type LIKE '{0}%'",type);
            string fail = string.Format("SELECT * FROM Inventory1");
            try
            {
                con.Open();
                text.CommandText = sql;
                SqlDataReader pull = text.ExecuteReader();

                while (pull.Read())
                {
                    int Id = pull.GetInt32(0);
                    string brand = pull.GetString(1);
                    string name = pull.GetString(2);
                    SqlDecimal price = pull.GetSqlDecimal(4);
                    string desc = pull.GetString(5);
                    string img = pull.GetString(6);

                    Choco choco = new Choco(Id, brand,name,price,desc,img);
                    Details.Add(choco);
                }
            }



            finally
            {
                con.Close();
            }
            return Details;
        }

        public static bool GetCredentials(string username, string password)
        {
            con.Open();
            string sql = string.Format("SELECT * FROM Credentials WHERE Username='" + username + "' and Password='" + password + "'");
            text.CommandText = sql;
            SqlDataReader check = text.ExecuteReader();
            if (check.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public static void AddChoco(Choco choco)
        {
            con.Open();
            string query = string.Format("INSERT INTO Inventory1 VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", choco.brand, choco.name, choco.type, choco.price, choco.desc ,choco.img);
            text.CommandText = query;
            try
            {
                text.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
                text.Parameters.Clear();
            }
        }

        public static string DoInsert(string title, string email, string feedback)
        {
            StringBuilder sb = new StringBuilder();
            string sql = string.Format("INSERT INTO Feedback VALUES('{0}','{1}','{2}')" ,title, email, feedback);
            text.CommandText = sql;
            con.Open();
            int k = text.ExecuteNonQuery();
            if (k != 0)
            {
                sb = sb.Append(string.Format("Feedback succesfully sent and we will get back to you as soon as possible"));
            }
            con.Close();
            return sb.ToString();
        }

        public static string DeleteChoc(string Id)
        {
            StringBuilder sb = new StringBuilder();
            string sql = string.Format("DELETE FROM Inventory1 WHERE Id LIKE '{0}'", Id);
            text.CommandText = sql;
            con.Open();
            int test = text.ExecuteNonQuery();
            if (test != 0)
            {
                sb = sb.Append(string.Format("Chocolate successfully deleted!"));
            }
            con.Close();
            return sb.ToString();
        }

        public static void EditChoco(Choco choco, string Id)
        {
            con.Open();
            string query = string.Format("UPDATE Inventory1 SET brand = '{0}',name = '{1}',type = '{2}',price = '{3}',description = '{4}',image = '{6}' WHERE Id LIKE '{5}'", choco.brand, choco.name, choco.type, choco.price, choco.desc, Id, choco.img);
            text.CommandText = query;
            try
            {
                text.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
                text.Parameters.Clear();
            }
        }
    }
}