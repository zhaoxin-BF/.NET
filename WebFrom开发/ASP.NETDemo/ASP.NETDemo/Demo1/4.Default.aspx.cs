using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo
{
    public partial class _4_Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                this.Textnum1.Text = "请输入文本";
            }
        }

        protected void btnPass_Click(object sender, EventArgs e)
        {
            this.Textnum2.Text = this.Textnum1.Text;
        }
    }
}