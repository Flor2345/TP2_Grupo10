<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4.aspx.cs" Inherits="TP2_Grupo10.Ejercicio4aspx" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <title>Login - Ejercicio 4</title>
    <style>
        body {
            background-color: #f2f2f2;
            font-family: Arial, sans-serif;
        }

        .login-container {
            background-color: white;
            padding: 25px;
            border-radius: 8px;
            box-shadow: 0 0 8px rgba(0, 0, 0, 0.1);
            width: 320px;
            margin: 80px auto;
        }

        .login-row {
            margin-bottom: 15px;
        }

        label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .login-input {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .login-button {
            width: 100%;
            padding: 10px;
            background-color: #dddddd;
            border: none;
            border-radius: 4px;
            font-weight: bold;
            cursor: pointer;
        }

        .login-button:hover {
            background-color: #c4c4c4;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <div class="login-row">
                <label for="txtUsuario">Usuario:</label>
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="login-input"></asp:TextBox>
            </div>

            <div class="login-row">
                <label for="txtClave">Clave:</label>
                <asp:TextBox ID="txtClave" runat="server" CssClass="login-input" TextMode="Password"></asp:TextBox>
            </div>

            <div class="login-row">
                <asp:Button ID="Button_Validar" runat="server" Text="Validar" CssClass="login-button" OnClick="Button_Validar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
