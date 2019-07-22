using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;

namespace ForumSystem
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //封装登录信息
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId =  this.Textumame.Text.Trim(),
                LoginPwd  = this.Textupwd.Text.Trim()
            };

            //调用数据访问类查询用户信息
            try
            {
                objAdmin = new AdminService().AdminLogin(objAdmin);
                if(objAdmin == null)
                {
                    this.ltaInfo.Text = "<script>altert('用户名密码错误！')</script>";
                }
                else
                {
                    Session["CurrentUser"] = objAdmin;
                    Response.Redirect("~/Default.aspx");
                }
            }
            catch(Exception ex)
            {
                this.ltaInfo.Text = "<script>alter('"+ ex.Message +"')</script>";
            }
        }

    }
}