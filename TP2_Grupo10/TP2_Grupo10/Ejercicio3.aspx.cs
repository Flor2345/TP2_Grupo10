using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo10
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton_Azul_Click(object sender, EventArgs e)
        {
            // Cambia el texto y el color del label al hacer clic en el LinkButton
            lblTextoColoreado.Text = "El color seleccionado es Azul";
            lblTextoColoreado.ForeColor = System.Drawing.Color.Blue;
        }

        protected void btnVolverMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioPrincipal.aspx");
        }
    }
}