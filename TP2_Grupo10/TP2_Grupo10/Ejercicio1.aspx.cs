using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo10
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGenerarTabla_Click(object sender, EventArgs e)
        {
            //Casteo los numero de la text box como int y a los productos como string y los guardo en variables
            int cantidad1 = int.Parse(txtCantidadIngreso1.Text);
            int cantidad2 = int.Parse(txtCantidadIngreso2.Text);
            string producto1 = txtProductoIngreso1.Text;
            string producto2 = txtProductoIngreso2.Text;

            //Construyo la tabla (No corresponde a mi aporte)

            //Cambio el texto del label (tampoco corresponde)

            //Limpio los text box
            txtCantidadIngreso1.Text = "";
            txtCantidadIngreso2.Text = "";
            txtProductoIngreso1.Text = "";
            txtProductoIngreso2.Text = "";
        }
    }
}