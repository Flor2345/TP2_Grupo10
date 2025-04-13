<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio5.aspx.cs" Inherits="TP2_Grupo10.Ejercicio5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                               <asp:Label ID="Label_Titulo" runat="server" Font-Size="XX-Large" Font-Bold="True" ForeColor="Black" Style="white-space: nowrap;">Elija su configuracion</asp:Label>
                           </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>Seleccione cantidad de memoria:</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                               <asp:DropDownList ID="DDL_Memoria" runat="server" Width="232px" AutoPostBack="True">
                                   <asp:ListItem Value="0">Seleccione una opcion</asp:ListItem>
                                   <asp:ListItem Value="1">2 GB</asp:ListItem>
                                   <asp:ListItem Value="2">4 GB</asp:ListItem>
                                   <asp:ListItem Value="3">6 GB</asp:ListItem>
                               </asp:DropDownList>
                           </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>Seleccione accesorios:</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                               <asp:CheckBoxList ID="CBL_Accesorios" runat="server" AutoPostBack="True">
                                   <asp:ListItem Value="1">Monitor LCD</asp:ListItem>
                                   <asp:ListItem Value="2">HD 500GB</asp:ListItem>
                                   <asp:ListItem Value="3">Grabador DVD</asp:ListItem>
                               </asp:CheckBoxList>
                           </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                               <asp:Button ID="Button_Calcular" runat="server" OnClick="Button_Calcular_Click" Text="Calcular Precio" />
                           </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                               <asp:Label ID="Precio_Final" runat="server"></asp:Label>
                           </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
