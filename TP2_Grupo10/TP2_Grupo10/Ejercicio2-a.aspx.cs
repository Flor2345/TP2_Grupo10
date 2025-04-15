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
        bool nombreValido;
        bool apellidoValido;
        bool ciudadValidado;
        bool temaValidado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ScriptManager.ScriptResourceMapping.AddDefinition(
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

        }

        protected void btnVerResumen_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();

            nombreValido = validaciones.EsTextoValido(txtNombre, CustomValidator_Nombre, "Nombre");
            apellidoValido = validaciones.EsTextoValido(txtApellido, CustomValidator_Apellido, "Apellido");
            ciudadValidado = validaciones.Validar_DropDownList(DropDownList_Ciudad, RFV_Ciudad);
            temaValidado = validaciones.Validar_ChekBpxList(CheckBoxList_Temas, CV_Temas, " Elija al menos un Tema.");

            if (nombreValido && apellidoValido && ciudadValidado && temaValidado)
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
            else
            {
                CustomValidator_Nombre.IsValid = false;
                CustomValidator_Apellido.IsValid = false;
                RFV_Ciudad.IsValid = false;
                CV_Temas.IsValid = false;

            }
        }

        protected void CustomValidator_Nombre_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Validaciones validaciones = new Validaciones();

            nombreValido = validaciones.EsTextoValido(txtNombre, CustomValidator_Nombre, "Nombre");
            args.IsValid = nombreValido;
        }

        protected void CustomValidator_Apellido_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Validaciones validaciones = new Validaciones();
          
            apellidoValido = validaciones.EsTextoValido(txtApellido, CustomValidator_Apellido, "Apellido");
            args.IsValid = apellidoValido;
        }

    }
}

