using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo10
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVerResumen_Click(object sender, EventArgs e)
        {
            List<string> seleccionados = new List<string>();

            foreach (ListItem item in CheckBoxList_Temas.Items)
            {
                if (item.Selected)
                {
                    seleccionados.Add(item.Text);
                }
            }

            Session["Seleccionados"] = seleccionados;

            Server.Transfer("Ejercicio2-b.aspx");

        }
    }
}