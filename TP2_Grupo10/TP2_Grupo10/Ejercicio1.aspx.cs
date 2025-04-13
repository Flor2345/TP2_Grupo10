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
            ScriptManager.ScriptResourceMapping.AddDefinition
             (
                    "jquery",
                    new ScriptResourceDefinition
                    {
                        Path = "~/Scripts/jquery-3.6.0.min.js",
                        DebugPath = "~/Scripts/jquery-3.6.0.js",
                        CdnPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.6.0.min.js",
                        CdnDebugPath = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.6.0.js"
                    }
             );
        }


        // Valida los nombres de producto ingresados en el servidor.
        protected void ValidarIngresos_Nombres_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Validaciones validaciones = new Validaciones();
            // Llama a la lógica de validación y actualiza el estado de validez (args.IsValid).
            args.IsValid = validaciones.Validar_NombresProductos(txtProductoIngreso1, txtProductoIngreso2, Validar_IngresosP);
        }

        // Valida las cantidades de producto ingresadas en el servidor.
        protected void ValidarIngresos_Cantidades_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Validaciones validaciones = new Validaciones();
            // Llama a la lógica de validación y actualiza el estado de validez (args.IsValid).
            args.IsValid = validaciones.Validar_Cantidades(txtCantidadIngreso1, txtCantidadIngreso2, Validar_IngresosC);
        }


        // --------------------  Metodos para restaura el color del fondo de cada campo -------------------- 
        protected void Restaurar_ColorFondo_Producto1(object sender, EventArgs e)
        {
            txtProductoIngreso1.BackColor = System.Drawing.Color.White;
        }

        protected void Restaurar_ColorFondo_Producto2(object sender, EventArgs e)
        {
            txtProductoIngreso2.BackColor = System.Drawing.Color.White;
        }

        protected void Restaurar_ColorFondo_Cantidad1(object sender, EventArgs e)
        {
            txtCantidadIngreso1.BackColor = System.Drawing.Color.White;
        }

        protected void Restaurar_ColorFondo_Cantidad2(object sender, EventArgs e)
        {
            txtCantidadIngreso2.BackColor = System.Drawing.Color.White;
        }
        //---------------------------------------------------------------------------------------------------

        protected void BtnGenerarTabla_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
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
                Restaurar_ColorFondo_Producto1(sender, e);
                Restaurar_ColorFondo_Producto2(sender, e);
                Restaurar_ColorFondo_Cantidad1(sender, e);
                Restaurar_ColorFondo_Cantidad2(sender, e);

            }
            
        }
    }
}