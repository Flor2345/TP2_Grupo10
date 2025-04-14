<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2-a.aspx.cs" Inherits="TP2_Grupo10.Ejercicio2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Ejercicio 2-A</title>
    <style>
        body {
            background-color: #f4f4f4;
            font-family: Arial, sans-serif;
            padding: 20px;
        }

        .form-container {
            background-color: white;
            padding: 20px 30px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            max-width: 600px;
            margin: auto;
        }

        .form-row {
            margin-bottom: 15px;
        }

        .form-label {
            display: inline-block;
            width: 100px;
            font-weight: bold;
        }

        .form-input {
            width: 250px;
        }

        .form-checkboxlist {
            margin-left: 100px;
        }

        .btn-resumen {
            margin-left: 100px;
            padding: 8px 16px;
            background-color: #dcdcdc;
            border: 1px solid #aaa;
            border-radius: 4px;
            cursor: pointer;
        }

        .btn-resumen:hover {
            background-color: #c0c0c0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <div class="form-row">
                <label class="form-label">Nombre:</label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-input"></asp:TextBox>
            </div>

            <div class="form-row">
                <label class="form-label">Apellido:</label>
                <asp:TextBox ID="txtApellido" runat="server" CssClass="form-input"></asp:TextBox>
            </div>

            <div class="form-row">
                <label class="form-label">Ciudad:</label>
                <asp:DropDownList ID="DropDownList_Ciudad" runat="server" Width="256px" AutoPostBack="True">
                    <asp:ListItem Value="Seleccione una opcion">Seleccione una opcion</asp:ListItem>
                    <asp:ListItem Value="Oeste">San Miguel</asp:ListItem>
                    <asp:ListItem Value="Sur">Boedo</asp:ListItem>
                    <asp:ListItem Value="Norte">Gral. Pacheco</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-row">
                <label class="form-label">Temas:</label>
                <asp:CheckBoxList ID="CheckBoxList_Temas" runat="server" CssClass="form-checkboxlist" AutoPostBack="True">
                    <asp:ListItem Value="1">Ciencias</asp:ListItem>
                    <asp:ListItem Value="2">Literatura</asp:ListItem>
                    <asp:ListItem Value="3">Historia</asp:ListItem>
                </asp:CheckBoxList>
            </div>

            <div class="form-row">
                <asp:Button ID="btnVerResumen" runat="server" CssClass="btn-resumen" Text="Ver resumen" OnClick="btnVerResumen_Click" />
            </div>
        </div>
    </form>
</body>
</html>