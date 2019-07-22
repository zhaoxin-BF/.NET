using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo
{
    public partial class _3_CalDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCal_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.num1.Text.Trim());
            int b = Convert.ToInt32(this.num2.Text.Trim());
            this.numSult.Text = (a + b).ToString();
        }
    }
}