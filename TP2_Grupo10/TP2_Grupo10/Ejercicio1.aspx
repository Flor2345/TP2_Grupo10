<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_Grupo10.Ejercicio1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta charset="utf-8"/>
  <title>Ejercicio 1</title>
  <style>
    body {
        background-color: #f2f2f2;
        font-family: Arial, sans-serif;
    }

    .form-container {
        background-color: #fff;
        max-width: 700px;
        margin: 50px auto;
        padding: 30px;
        border-radius: 10px;
        box-shadow: 0 0 10px rgba(0,0,0,0.1);
    }

    .form-row {
        display: flex;
        align-items: center;
        margin-bottom: 15px;
    }

    .form-row label {
        width: 220px;
        font-weight: bold;
    }

    .form-row input[type="text"] {
        width: 200px;
        padding: 5px;
        border: 1px solid #ccc;
        border-radius: 4px;
    }

    .form-row .validador {
        margin-left: 10px;
        color: red;
        font-size: 12px;
    }

    .button-row {
        margin-top: 20px;
    }

    .button-row input {
        padding: 8px 16px;
        margin-right: 15px;
        border: 1px solid #aaa;
        background-color: #e0e0e0;
        border-radius: 5px;
        cursor: pointer;
    }

    .button-row input:hover {
        background-color: #d2d2d2;
    }

    .lbl-tabla {
        margin-top: 20px;
        font-weight: bold;
    }
  </style>
</head>
<body>
  <form id="form1" runat="server">
    <div class="form-container">
      <asp:Panel ID="Panel1" runat="server">

        <!-- Producto 1 -->
        <div class="form-row">
          <label for="txtProductoIngreso1">Nombre del producto 1:</label>
          <asp:TextBox ID="txtProductoIngreso1" runat="server" AutoPostBack="True" OnTextChanged="Restaurar_ColorFondo_Producto1"></asp:TextBox>
        </div>

        <div class="form-row">
          <label for="txtCantidadIngreso1">Cantidad:</label>
          <asp:TextBox ID="txtCantidadIngreso1" runat="server" AutoPostBack="True" OnTextChanged="Restaurar_ColorFondo_Cantidad1"></asp:TextBox>
        </div>

        <!-- Producto 2 -->
        <div class="form-row">
          <label for="txtProductoIngreso2">Nombre del producto 2:</label>
          <asp:TextBox ID="txtProductoIngreso2" runat="server" AutoPostBack="True" OnTextChanged="Restaurar_ColorFondo_Producto2"></asp:TextBox>
        </div>

        <div class="form-row">
          <label for="txtCantidadIngreso2">Cantidad:</label>
          <asp:TextBox ID="txtCantidadIngreso2" runat="server" AutoPostBack="True" OnTextChanged="Restaurar_ColorFondo_Cantidad2"></asp:TextBox>
        </div>

        <!-- Validadores -->
        <div class="form-row">
          <asp:CustomValidator ID="Validar_IngresosP" runat="server" OnServerValidate="ValidarIngresos_Nombres_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True" CssClass="validador"></asp:CustomValidator>
        </div>

        <div class="form-row">
          <asp:CustomValidator ID="Validar_IngresosC" runat="server" OnServerValidate="ValidarIngresos_Cantidades_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True" CssClass="validador"></asp:CustomValidator>
        </div>

        <!-- Botones -->
        <div class="button-row">
          <asp:Button ID="BtnGenerarTabla" runat="server" OnClick="BtnGenerarTabla_Click" Text="Generar tabla" />
          <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver al formulario principal" />
        </div>

        <!-- Resultado -->
        <div class="lbl-tabla">
          <asp:Label ID="LblTabla" runat="server"></asp:Label>
        </div>

      </asp:Panel>
    </div>
  </form>
</body>
</html>
