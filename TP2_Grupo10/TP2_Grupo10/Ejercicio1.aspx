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
        .auto-style2 {
            width: 908px;
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
                        <asp:TextBox ID="txtProductoIngreso1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">
                        <asp:Label ID="lblCantidadIngreso1" runat="server" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtCantidadIngreso1" runat="server"></asp:TextBox>
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
                        <asp:TextBox ID="txtProductoIngreso2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style14">
                        <asp:Label ID="lblCantidadIngreso2" runat="server" Text="Cantidad:"></asp:Label>
                    </td>
                    <td class="auto-style13">&nbsp;</td>
                    <td>
                        <asp:TextBox ID="txtCantidadIngreso2" runat="server"></asp:TextBox>
                    </td>
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
                    <td class="auto-style16">&nbsp;</td>
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
            </table>
        </asp:Panel>
    </div>
      <asp:Panel ID="Panel2" runat="server" Width="130px">
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
      </asp:Panel>
  </form>
</body>
</html>