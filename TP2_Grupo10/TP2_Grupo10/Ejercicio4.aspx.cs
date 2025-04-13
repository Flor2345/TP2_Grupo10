using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo10
{
    public partial class Ejercicio4aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button_Validar_Click(object sender, EventArgs e)
        {
            string mensaje;

            // if () Para su posterior uso para las validaciones
            //{
            if (txtUsuario.Text == "claudio" && txtClave.Text == "casas")
            {
                mensaje = "Bienvenido a mi página Sr./a Claudio";
            }
            else
            {
                mensaje = "INGRESO INVALIDO INGRESO NO PERMITIDO";
            }

            Response.Redirect("Ejercicio4b.aspx?UsuarioMensaje=" + mensaje, false);


            // }
            /* else
             {

             }*/
        }
    }
}