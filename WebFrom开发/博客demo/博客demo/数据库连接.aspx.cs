using System.Collections;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Windows.Forms;
namespace 博客demo
{
    public partial class 数据库连接 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }



        protected void 查询_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=localhost;Initial Catalog=UserAndPassword;User ID=sa;Password=mima";
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = cnn;
            cnn.Open();
            cmm.CommandText = "SELECT [name],[passwd] from usertable";
            SqlDataReader sqlread = cmm.ExecuteReader();
            while (sqlread.Read())
            {
                Response.Write(sqlread["name"].ToString() + sqlread["passwd"].ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=localhost;Initial Catalog=UserAndPassword;User ID=sa;Password=mima";
            cnn.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = cnn;
            cmm.Parameters.Add("@name", SqlDbType.NVarChar);
            cmm.Parameters.Add("@passwd", SqlDbType.NVarChar);
            cmm.Parameters["@name"].Value = id.Text;
            cmm.Parameters["@passwd"].Value = password.Text;
            cmm.CommandText = "Insert Into usertable(name,passwd) Values(@name,@passwd)";
            cmm.ExecuteNonQuery();
            cnn.Close();
            Response.Write("插入成功");
            Response.Write(id.Text);
            Response.Write(password.Text);
        }

        protected void 登录_Click(object sender, EventArgs e)
        {
            int i = 1;
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=localhost;Initial Catalog=UserAndPassword;User ID=sa;Password=mima";
            cnn.Open();
            SqlCommand cmm = new SqlCommand();
            cmm.Connection = cnn;
            cmm.Parameters.Add("@name", SqlDbType.NVarChar);
            cmm.Parameters.Add("@passwd", SqlDbType.NVarChar);
            cmm.Parameters["@name"].Value = id.Text;
            cmm.Parameters["@passwd"].Value = password.Text;
            cmm.CommandText = "SELECT [name],[passwd] from usertable";
            SqlDataReader sqlread = cmm.ExecuteReader();
            while (sqlread.Read())
            {

                if (sqlread["name"].ToString().Trim() == id.Text.ToString().Trim() && sqlread["passwd"].ToString().Trim() == password.Text.ToString().Trim())
                {
                    MessageBox.Show("登陆成功");
                    i = 2;
                }
                if(i==1)
                    MessageBox.Show("登陆失败");

            }
        }
    }
}