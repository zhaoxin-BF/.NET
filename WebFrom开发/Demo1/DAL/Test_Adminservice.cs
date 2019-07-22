using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

using Models;
using DAL.SQLHelper;

namespace DAL
{
    public class Test_Adminservice
    {
         public  SysAdmin Test_AdminLogin(SysAdmin objAdmin)
        {
            string LoginId = objAdmin.LoginId;
            string LoginPwd = objAdmin.LoginPwd;
            int LoginType = objAdmin.LoginType;

            string sqlStr = "select LoginName from UserInfo where LoginId='" + LoginId + "' and LoginPwd='" + LoginPwd + "'and LoginType=" + LoginType + "";

            SqlDataReader sdr = SqlConnect.GetReader(sqlStr);

            if (sdr.Read())
            {
                objAdmin.LoginName = sdr["LoginName"].ToString();
            }
            else
            {
                objAdmin = null;
            }

            return objAdmin;
        }
    }
}
