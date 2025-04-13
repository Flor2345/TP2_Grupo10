using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEjercicio1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio1.aspx");
        }

        protected void btnEjercicio3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3.aspx");
        }

        protected void btnEjercicio2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2-a.aspx");
        }

        protected void btnEjercicio4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio4.aspx");
        }
    }
}