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
            SqlConnection conn = new SqlConnection("server=.;database=论坛系统数据库;uid=sa;pwd=123456");


            string LoginId = objAdmin.LoginId;
            string LoginPwd = objAdmin.LoginPwd;
            int LoginType = objAdmin.LoginType;

            //创建要执行的sql语句
            string sqlStr = "select LoginName from UserInfo where LoginId='" + LoginId + "' and LoginPwd='" + LoginPwd + "'and LoginType="+LoginType+"";

            //创建执行语句的对象
            SqlCommand comm = new SqlCommand(sqlStr, conn);
            conn.Open();

            //执行语句
            SqlDataReader sdr = comm.ExecuteReader();

            if(sdr.Read())
            {
                objAdmin.LoginName = sdr["LoginName"].ToString();
            }
            else
            {
                objAdmin = null;
            }
            sdr.Close();
            conn.Close();
            return objAdmin;
        }

        public Boolean AdminRegister(SysAdmin objAdmin)
        {
            SqlConnection conn = new SqlConnection("server=.;database=论坛系统数据库;uid=sa;pwd=123456");


            string LoginId = objAdmin.LoginId;
            string LoginName = objAdmin.LoginName;
            string LoginPwd = objAdmin.LoginPwd;
            int LoginType = objAdmin.LoginType;

            //创建要执行的sql语句
            string sqlStr = "insert into UserInfo values('"+LoginId+"','"+LoginName+"','"+LoginPwd+"',"+LoginType+")";

            //创建执行语句的对象
            SqlCommand comm = new SqlCommand(sqlStr, conn);
            conn.Open();

            //执行语句
            int sdr = comm.ExecuteNonQuery();

            if (sdr == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            conn.Close();
        }
    }
}
