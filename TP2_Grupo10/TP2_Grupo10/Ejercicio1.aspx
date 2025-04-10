<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_Grupo10.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Ejercicio 1</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <table class="auto-style1" border="1">
        <tr>
          <td class="auto-style2"><strong>Producto</strong></td>
          <td class="auto-style2"><strong>Cantidad</strong></td>
        </tr>
        <!-- Productos agregados de manera dinámica acá para abajo. -->
        <tr>
          <td><strong>TOTAL</strong></td>
          <td id="celdaTotal">0</td>
        </tr>
      </table>
    </div>
  </form>
</body>
</html>