using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

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
            //Variables
            string mensaje = "";

            //Validando que se haya escrito algo adentro
            if (txtClave.Text != "" && txtUsuario.Text != "")
            {
                //Validacion de que el usuario y contraseña coincidan
                if (txtUsuario.Text == "claudio" && txtClave.Text == "casas")
                {
                    //Cambio la variable mensaje
                    mensaje = "Bienvenido a mi página Sr./a Claudio";
                    //Redireccion
                    Response.Redirect("Ejercicio4b.aspx?mensajeB=" + Server.UrlEncode(mensaje));
                }
                else
                {
                    //Cambio la variable mensaje
                    mensaje = "INGRESO INVALIDO INGRESO NO PERMITIDO";
                    //Redireccion
                    Response.Redirect("Ejercicio4c.aspx?mensajeE=" + Server.UrlEncode(mensaje));
                }
            }
            else
            {
                //Mensaje de error
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Debe rellenar todos los campos');", true);
            }
        }
    }
}