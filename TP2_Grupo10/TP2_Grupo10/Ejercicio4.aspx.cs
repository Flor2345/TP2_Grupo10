using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace TP2_Grupo10
{
    public partial class Ejercicio4aspx : System.Web.UI.Page
    {
        string nombre;
        string apellido;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button_Validar_Click(object sender, EventArgs e)
        {
            //Variables
            nombre = "claudio";
            apellido = "casas";
            string mensaje = "";
            string nombreCapitalizado = char.ToUpper(nombre[0]) + nombre.Substring(1); 
            

            //Validando que se haya escrito algo adentro
            if (txtClave.Text != "" || txtUsuario.Text != "")
            {
                //Validacion de que el usuario y contraseña coincidan
                if (txtUsuario.Text == nombre && txtClave.Text == apellido)
                {
                    //Cambio la variable mensaje
                    mensaje = "Bienvenido a mi página Sr./a " + nombreCapitalizado;
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