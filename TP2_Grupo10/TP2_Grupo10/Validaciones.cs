using System;
using System.Collections.Generic;
using System.Drawing;
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
            // Verifica si el campo está vacío.
            if (string.IsNullOrEmpty(textBox.Text))
            {
                customValidator.ErrorMessage = "Campo de " + nombre + " incompleto.";
                textBox.BackColor = Color.LightCoral; 
                return false;
            }
            // Verifica si el texto contiene caracteres diferentes a letras y espacios.
            else if (!Regex.IsMatch(textBox.Text, @"^[a-zA-Z\s]+$"))
            {
                customValidator.ErrorMessage = nombre + " contiene numeros o caracteres invalidos.";
                textBox.BackColor = Color.LightCoral; 
                return false;
            }
            // Verifica si la longitud del texto excede el límite de 30 caracteres.
            else if (textBox.Text.Length > 30) 
            {
                customValidator.ErrorMessage = "El " + nombre + " ingresado no pueden superar los 30 caracteres.";
                textBox.BackColor = Color.LightCoral; 
                return false;
            }
            else
            {
                textBox.BackColor = Color.LightGreen;
                customValidator.ErrorMessage = "";
                return true;
            }
        }

      
        public bool EsNumeroValido(TextBox textBox, CustomValidator customValidator, string nombre)
        {
            // Verifica si el campo está vacío.
            if (string.IsNullOrEmpty(textBox.Text))
            {
                customValidator.ErrorMessage = "Campo de " + nombre + " incompleto.";
                textBox.BackColor = Color.LightCoral; 
                return false;
            }
            // Verifica si el texto contiene caracteres que no sean dígitos.
            else if (!Regex.IsMatch(textBox.Text, @"^\d+$"))
            {
                customValidator.ErrorMessage = "La " + nombre + " ingresada solo pueden contener números enteros positivos.";
                textBox.BackColor = Color.LightCoral; 
                return false;
            }
            // Verifica si el número convertido excede el límite de 1000.
            else if (Convert.ToInt32(textBox.Text) > 1000)
            {
                customValidator.ErrorMessage = "La " + nombre + " ingresada no pueden superar los 1000."; // Mensaje ajustado al código
                textBox.BackColor = Color.LightCoral; // Indica error visualmente.
                return false;
            }
            // Verifica si el valor ingresado es exactamente "0".
            else if (textBox.Text == "0")
            {
                customValidator.ErrorMessage = "No se puede ingresar 0 como " + nombre + ".";
                textBox.BackColor = Color.LightCoral; 
                return false;
            }
            else
            {
                textBox.BackColor = Color.LightGreen; 
                return true;
            }
        }


        public bool Validar_NombresProductos(TextBox TextBox_Producto1, TextBox TextBox_Producto2, CustomValidator Validar_IngresosP)
        {
            bool aux1 = true; 
            bool aux2 = true; 

            // Valida individualmente cada nombre de producto.
            aux1 = EsTextoValido(TextBox_Producto1, Validar_IngresosP, "Nombre de Producto");
            aux2 = EsTextoValido(TextBox_Producto2, Validar_IngresosP, "Nombre de Producto");

            // Si alguna de las validaciones individuales falló, retorna false.
            if (!aux1 || !aux2)
            {
                // El mensaje de error ya fue establecido por EsTextoValido.
                return false;
            }
            // Verifica si los nombres de los productos son idénticos.
            else if (TextBox_Producto1.Text == TextBox_Producto2.Text)
            {
                Validar_IngresosP.ErrorMessage = "Los nombres de los productos no pueden ser iguales.";
                TextBox_Producto1.BackColor = Color.LightCoral; 
                TextBox_Producto2.BackColor = Color.LightCoral;
                return false;
            }

            // Si todas las validaciones pasan, limpia el mensaje de error y retorna true.
            Validar_IngresosP.ErrorMessage = "";
            return true;
        }


        public bool Validar_Cantidades(TextBox TextBox_Cantidad1, TextBox TextBox_Cantidad2, CustomValidator Validar_IngresosC)
        {
            bool aux1 = true;
            bool aux2 = true; 

            // Valida individualmente cada cantidad.
            aux1 = EsNumeroValido(TextBox_Cantidad1, Validar_IngresosC, "Cantidad");
            aux2 = EsNumeroValido(TextBox_Cantidad2, Validar_IngresosC, "Cantidad");

            // Si alguna de las validaciones individuales falló, retorna false.
            if (!aux1 || !aux2)
            {
                return false;
            }

            // Si ambas validaciones pasan, limpia el mensaje de error y retorna true.
            Validar_IngresosC.ErrorMessage = "";
            return true;
        }

        public bool Validar_DropDownList(DropDownList dropDownList, RequiredFieldValidator Validar_IngresosD)
        {
            if (dropDownList.SelectedIndex == 0)
            {
                dropDownList.BackColor = System.Drawing.Color.LightCoral;
                Validar_IngresosD.Visible = true;
                return false;
            }
            else
            {
                dropDownList.BackColor = System.Drawing.Color.LightGreen;
                Validar_IngresosD.Visible = false;
                return true;
            }
        }

        public bool Validar_ChekBpxList(CheckBoxList checkBoxList, CustomValidator Validar_IngresosCB, string error)
        {

            if (checkBoxList.SelectedIndex == -1)
            {
                Validar_IngresosCB.ErrorMessage = error;
                checkBoxList.BackColor = System.Drawing.Color.LightCoral;
                return false;
            }
            else
            {
                Validar_IngresosCB.ErrorMessage = "";
                checkBoxList.BackColor = System.Drawing.Color.LightGreen;
                return true;
            }
        }
    }
}
