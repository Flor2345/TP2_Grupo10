using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo10
{
	public partial class Ejercicio2_b : System.Web.UI.Page
	{
        protected void Page_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Request["txtNombre"];
            lblApellido.Text = Request["txtApellido"];
            lblZona.Text = Request["DropDownList_Ciudad"];

            if (lblZona.Text == "Seleccione una opcion")
            {
                lblZona.Text = "";
            }

            List<string> seleccionados = Session["Seleccionados"] as List<string>;

            foreach (string texto in seleccionados)
            {
                TableRow fila = new TableRow();
                TableCell celda = new TableCell();

                celda.Text = texto;
                fila.Cells.Add(celda);

                tblTemas.Rows.Add(fila);
            }
        }


        protected void btnVerResumen_Click(object sender, EventArgs e)
        {
            Server.Transfer("FormularioPrincipal.aspx");
        }

        protected void btnVolverAEjercicio2a_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio2-a.aspx");
        }
    }
}