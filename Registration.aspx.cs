using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection SqlCon = new SqlConnection();
        SqlCommand com = new SqlCommand();
        string myConnectionString = ConfigurationManager.ConnectionStrings["StrCon"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlCon.ConnectionString = (myConnectionString);
                SqlCon.Open();
                com.Connection = SqlCon;
                com.CommandText = "INSERT INTO [dbo].[Registration Details] (Name,Mobile,EmailId) VALUES (@Name,@Mobile,@Email)";
                com.Parameters.AddWithValue("@Name", textName.Text.Trim());
                com.Parameters.AddWithValue("@Mobile", textMobilenumber.Text.Trim());
                com.Parameters.AddWithValue("@Email", textMailId.Text.Trim());
                com.ExecuteNonQuery();
                SqlCon.Close();

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
    }
}