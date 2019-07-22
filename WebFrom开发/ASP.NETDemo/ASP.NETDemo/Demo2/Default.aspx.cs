using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETDemo.Demo2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ViewState["Counter"] = 0;
                this.Literal1.Text = "0";
            }
        }

        protected void btnCal_Click(object sender, EventArgs e)
        {
            int counter = (int)ViewState["Counter"];
            counter++;
            this.Literal1 .Text = counter.ToString();

            ViewState["Counter"] = counter;
        }
    }
}