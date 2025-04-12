using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;

namespace TP2_Grupo10
{
	public class Validaciones
	{

        public bool EsTextoValido(TextBox textBox, CustomValidator customValidator, string nombre)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                customValidator.ErrorMessage = "Campo de " + nombre + " incompleto.";
                textBox.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }
            else if (!Regex.IsMatch(textBox.Text, @"^[a-zA-Z\s]+$"))
            {
                customValidator.ErrorMessage = nombre + " contiene numeros o caracteres invalidos.";
                textBox.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }
            else if (textBox.Text.Length > 30 || textBox.Text.Length > 30)
            {
                customValidator.ErrorMessage = "El " + nombre + " ingresado no pueden superar los 30 caracteres.";
                textBox.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.LightGreen;
                return true;
            }
        }

        public bool EsNumeroValido(TextBox textBox, CustomValidator customValidator, string nombre)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                customValidator.ErrorMessage = "Campo de " + nombre + " incompleto.";
                textBox.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }
            else if (!Regex.IsMatch(textBox.Text, @"^\d+$"))
            {
                customValidator.ErrorMessage = "La " + nombre + " ingresada solo pueden contener números enteros positivos.";
                textBox.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }
            else if (Convert.ToInt32(textBox.Text) > 1000)
            {
                customValidator.ErrorMessage = "La " + nombre + " ingresada no pueden superar los 100.";
                textBox.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }
            else if (textBox.Text == "0")
            {
                customValidator.ErrorMessage = "No se puede ingresar 0 como " + nombre + ".";
                textBox.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.LightGreen;
                return true;
            }
        }

        public bool Validar_NombresProductos(TextBox TextBox_Producto1, TextBox TextBox_Producto2, CustomValidator Validar_IngresosP)
        {
            bool aux1 = true;
            bool aux2 = true;

            aux1 = EsTextoValido(TextBox_Producto1, Validar_IngresosP, "Nombre de Producto");
            aux2 = EsTextoValido(TextBox_Producto2, Validar_IngresosP, "Nombre de Producto");

            if (!aux1 || !aux2)
            {
                return false;
            }
            else if (TextBox_Producto1.Text == TextBox_Producto2.Text)
            {
                Validar_IngresosP.ErrorMessage = "Los nombres de los productos no pueden ser iguales.";
                TextBox_Producto1.BackColor = System.Drawing.Color.LightCoral;
                TextBox_Producto2.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }

            Validar_IngresosP.ErrorMessage = "";
            return true;
        }

        public bool Validar_Cantidades(TextBox TextBox_Cantidad1, TextBox TextBox_Cantidad2, CustomValidator Validar_IngresosC)
        {

            bool aux1 = true;
            bool aux2 = true;

            aux1 = EsNumeroValido(TextBox_Cantidad1, Validar_IngresosC, "Cantidad");
            aux2 = EsNumeroValido(TextBox_Cantidad2, Validar_IngresosC, "Cantidad");

            if (!aux1 || !aux2)
            {
                return false;
            }

            Validar_IngresosC.ErrorMessage = "";
            return true;
        }

    }
}