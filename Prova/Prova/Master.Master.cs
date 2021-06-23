using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prova
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblBemvindo.CssClass = "text text-light";
            lblBemvindo.Text = $"Olá <b>{Session["Nome"]}</b>, bem-vindo!";
        }
    }
}