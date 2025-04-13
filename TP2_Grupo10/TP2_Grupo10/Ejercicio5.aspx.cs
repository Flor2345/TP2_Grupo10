using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_Grupo10
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Calcular_Click(object sender, EventArgs e)
        {
            //if () Deberia validar si el usuario selecciono un item en el DropDownList y al menos un item en el CheckBoxList.*/|
            //{

            // Combierte el Value del item seleccionado a decimal (devolveria un 0 si fallara).
            decimal.TryParse(DDL_Memoria.SelectedValue, out decimal precioMemoriaDecimal);

            decimal sumaAccesorios = CBL_Accesorios.Items.Cast<ListItem>()
                                                  // Filtra los items seleccionados en el CheckBoxList.
                                                  .Where(i => i.Selected) 
                                                  // Combierte los valores Value de cada item seleccionado a decimal y los suma.
                                                  .Sum(i => decimal.TryParse(i.Value, out decimal valor) ? valor : 0);

            // Calcula el precio total sumando el precio de la memoria y los accesorios.
            decimal PrecioTotal = precioMemoriaDecimal + sumaAccesorios;

            // Muestra el precio total formateado como moneda.
            Precio_Final.Text = "El Precio final es de " + PrecioTotal.ToString("C2");
            //}
            //else
            //{
            //}
        }
    
    }
}