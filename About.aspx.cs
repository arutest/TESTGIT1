using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAruTest1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Response.Write("<h1>ESTA ES UNA PRUEBA DE ESCRITURA</h1>");
        }
    }
}