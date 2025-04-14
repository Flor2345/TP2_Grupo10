<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_Grupo10.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
  <title>Ejercicio 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style9 {
            width: 10px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
        .auto-style13 {
            width: 10px;
        }
        .auto-style14 {
            width: 44px;
        }
        .auto-style15 {
            height: 23px;
            width: 44px;
        }
        .auto-style16 {
            width: 200px;
        }
        .auto-style17 {
            width: 200px;
            height: 23px;
        }
        .auto-style18 {
            width: 170px;
        }
        .auto-style19 {
            width: 170px;
            height: 23px;
        }
    </style>
</head>
<body>
  <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style16">
                        <asp:Label ID="lblProductoIngreso1" runat="server" Text="Ingrese nombre del producto:"></asp:Label>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="txtProductoIngreso1" runat="server" AutoPostBack="True" OnTextChanged="Restaurar_ColorFondo_Producto1"></asp:TextBox>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">
                        <asp:Label ID="lblCantidadIngreso1" runat="server" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtCantidadIngreso1" runat="server" AutoPostBack="True" OnTextChanged="Restaurar_ColorFondo_Cantidad1"></asp:TextBox>
                        &nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style19"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Label ID="lblProductoIngreso2" runat="server" Text="Ingrese nombre del producto:"></asp:Label>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">
                        <asp:TextBox ID="txtProductoIngreso2" runat="server" AutoPostBack="True" OnTextChanged="Restaurar_ColorFondo_Producto2"></asp:TextBox>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">
                        <asp:Label ID="lblCantidadIngreso2" runat="server" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtCantidadIngreso2" runat="server" AutoPostBack="True" OnTextChanged="Restaurar_ColorFondo_Cantidad2"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style19">
                        <asp:CustomValidator ID="Validar_IngresosP" runat="server" OnServerValidate="ValidarIngresos_Nombres_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True"></asp:CustomValidator>
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style15"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style12">
                        <asp:CustomValidator ID="Validar_IngresosC" runat="server" OnServerValidate="ValidarIngresos_Cantidades_ServerValidate" SetFocusOnError="True" ValidateEmptyText="True"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Button ID="BtnGenerarTabla" runat="server" OnClick="BtnGenerarTabla_Click" Text="Generar tabla" Width="132px" />
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        &nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Label ID="LblTabla" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver al formulario principal" />
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </div>
  </form>
</body>
</html>