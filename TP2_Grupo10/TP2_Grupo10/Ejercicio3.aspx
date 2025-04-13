<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP2_Grupo10.Ejercicio3" %>

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
            height: 31px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:LinkButton ID="LnkBtnColorRojo" runat="server">Rojo</asp:LinkButton>                        
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                    <asp:LinkButton ID="LnkBtnColorAzul" runat="server" ForeColor="Blue" OnClick="LinkButton_Azul_Click">Azul</asp:LinkButton>
                    </td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td>(LinkButton3)</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblTextoColoreado" runat="server" Text="Texto coloreado"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
