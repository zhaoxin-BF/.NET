using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using DAL;
using Models;

namespace Demo1
{
    public partial class UserLogin : System.Web.UI.Page
    {
        SysAdmin objAdmin = new SysAdmin();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //SysAdmin objAdmin = new SysAdmin()
            //{
            //    LoginId = this.texLoginId.Text.Trim(),
            //    LoginPwd = this.texLoginPwd.Text.Trim()
            //};
            objAdmin.LoginId = this.texLoginId.Text.Trim();
            objAdmin.LoginPwd = this.texLoginPwd.Text.Trim();
            try
            {
                //objAdmin = new AdminService().AdminLogin(objAdmin);
                objAdmin = new Test_Adminservice().Test_AdminLogin(objAdmin);

                if (objAdmin == null)
                {
                    this.ltaInfo.Text = "用户名或密码错误！";
                }
                else
                {
                    Session["CurrentUser"] = objAdmin;
                    Response.Redirect("/views/Homepage.aspx");
                }
            }
            catch (Exception)
            {
                this.ltaInfo.Text = "发生异常！";
            }
        }

        protected void rbt0_CheckedChanged(object sender, EventArgs e)
        {
            objAdmin.LoginType = 0;
        }

        protected void rbt1_CheckedChanged(object sender, EventArgs e)
        {
            objAdmin.LoginType = 1;
        }
    }
}