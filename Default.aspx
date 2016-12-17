<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Página de Login</title>
    <link href="Estilo.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            height: 58px;
            width: 277px;
        }
        .style2
        {
            width: 277px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="login">
    
        <table style="width:100%; text-align: center">
            <tr>
                <td class="style1">
                    <img alt="Login" src="images/login_main.gif" 
                        style="width: 267px; height: 60px" /></td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;Login:<asp:TextBox ID="txtLogin" runat="server" Width="128px">symon</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Senha:<asp:TextBox ID="txtSenha" runat="server" TextMode="Password" 
                        Width="128px">232323</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:Button ID="btLogin" runat="server" Text="Logar" onclick="btLogin_Click" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtLogin" Display="Dynamic" 
                        ErrorMessage="E necessário digitar um Login!"></asp:RequiredFieldValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtSenha" Display="Dynamic" 
                        ErrorMessage="É necessário digitar uma Senha"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    </div>
    <div class="InfoLogin" style="height: 82px; width: 223px">
        <asp:Label ID="lblFalhaDeLogin" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
