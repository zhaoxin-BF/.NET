using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETDemo.Handers
{
    /// <summary>
    /// Login 的摘要说明
    /// </summary>
    public class Login : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //获取前台数据
            string uname = context.Request.Params["uname"];
            string upwd = context.Request.Params["upwd"];

            //调用数据访问方法判断是否正确
            DAL.AdminService objService = new DAL.AdminService();
            if(objService.AdminLogin(uname,upwd))
            {
                context.Response.Write("登录成功！");
            }else
            {
                context.Response.Write("用户名或密码错误！");
            }

        }

        public bool IsReusable//是否自动缓存
        {
            get
            {
                return false;
            }
        }
    }
}