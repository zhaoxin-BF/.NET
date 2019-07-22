using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Models;
 

namespace DAL
{
    public class AdminService
    {
        public SysAdmin AdminLogin(SysAdmin objAdmin)
        {
            string sql = "select LoginName from UserInfo where LoginId=@LoginId and LoginPwd=@LoginPwd";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@LoginId",objAdmin.LoginId),
                new SqlParameter("@LoginPwd", objAdmin.LoginPwd)
            };

            try
            {
                SqlDataReader objReader = DAL.Helper.SQLHelper.GetReader(sql, param, false);
                if(objReader.Read())
                {
                    objAdmin.LoginName = objReader["LoginName"].ToString();
                }
                else
                {
                    objAdmin = null;
                }
                objReader.Close();
            }
            catch(Exception ex)
            {
                throw new Exception("用户登录异常："+ex.Message);
            }
            return objAdmin;
        }
    }
}
