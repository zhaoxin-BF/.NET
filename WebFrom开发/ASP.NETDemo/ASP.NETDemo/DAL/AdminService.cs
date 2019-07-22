using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NETDemo.DAL
{
    public class AdminService
    {
        public bool AdminLogin(string name, string pwd)
        {
            //模拟从数据库访问
            if(name == "xiaowang" && pwd == "123456")
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}