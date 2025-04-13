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
        decimal precio1M = 200.00M;
        decimal precio2M = 375.00M;
        decimal precio3M = 500.00M;
        decimal precio1A = 2000.00M;
        decimal precio2A = 550.50M;
        decimal precio3A = 1200.00M;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Calcular_Click(object sender, EventArgs e)
        {
            //if () Deberia validar si el usuario selecciono un item en el DropDownList y al menos un item en el CheckBoxList.*/|
            //{
            decimal precioMemoria = 0;
            decimal precioTotalAccesorios = 0;
     

            if (DDL_Memoria.SelectedValue != "0")
            {
                if (DDL_Memoria.SelectedValue == "1")
                {
                    precioMemoria = precio1M;
                }
                else if (DDL_Memoria.SelectedValue == "2")
                {
                    precioMemoria = precio2M;
                }
                else if (DDL_Memoria.SelectedValue == "3")
                {
                    precioMemoria = precio3M;
                }


                foreach (ListItem item in CBL_Accesorios.Items)
                {
                    if (item.Selected)
                    {
                        // Suma los precio de los accesorios seleccionados.
                        if (item.Value == "1")
                        {
                            precioTotalAccesorios += precio1A;
                        }
                        else if (item.Value == "2")
                        {
                            precioTotalAccesorios += precio2A;
                        }
                        else if (item.Value == "3")
                        {
                            precioTotalAccesorios += precio3A;
                        }
                    }
                }

                // Calcula el precio total sumando el precio de la memoria y los accesorios.
                decimal PrecioTotal = precioMemoria + precioTotalAccesorios;

                // Muestra el precio total formateado como moneda.
                Precio_Final.Text = "El Precio final es de " + PrecioTotal.ToString("C2");
                //}
                //else
                //{
                //}
            }
        }
    
    }
}