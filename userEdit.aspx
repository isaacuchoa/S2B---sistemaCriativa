<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userEdit.aspx.cs" Inherits="projList" Title="Editar Usuário" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css"> 
        .style10
        {
            height: 22px;
        }
        .style15
        {
            height: 22px;
            width: 586px;
        }
        .style16
        {
            width: 586px;
            height: 16px;
        }
        .style17
        {
            height: 8px;
            width: 586px;
        }
        .style18
        {
            height: 60px;
            width: 586px;
        }
        .style20
        {
            height: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="titulo1">Editar Usauário</h1>
    <h6><asp:Label ID="lblInfor" runat="server" Text="Edite as informações que achar necessário, e click em Salvar Alterações."></asp:Label></h6>
    <table cellpadding="0" cellspacing="0" class="conteudo" style="width:100%;">
        <tr >
            <td class="style15">
                Nome Completo do Usuário<br />
                <asp:TextBox ID="txtNomeCompleto" runat="server" Width="228px">João Silva</asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtNomeCompleto" 
                    ErrorMessage="Digite um Nome para Usuário!" Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style17">
                Celular<br />
                <asp:TextBox ID="txtCelular" runat="server" Width="109px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                    ControlToValidate="txtCelular" ErrorMessage="Digite o Celular do Usuário." 
                    Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
            </tr>
        <tr>
            <td class="style17">
                Email<br />
                <asp:TextBox ID="txtEmail" runat="server" Width="242px">user@gmail.com</asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="Digite o Email do usuário." 
                    Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email inválido." 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
        <tr >
            <td class="style15">
                Login<br />
                <asp:TextBox ID="txtLogin" runat="server" Width="127px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtLogin" ErrorMessage="Digite um Login." 
                    Display="Dynamic"></asp:RequiredFieldValidator>
                </td>
        </tr>
        <tr>
            <td class="style16">
                Senha<br />
                <asp:TextBox ID="txtSenha" runat="server" Width="125px" TextMode="Password"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td class="style17">
                Confirme a Senha<br />
                <asp:TextBox ID="txtSenha2" runat="server" TextMode="Password" Width="125px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="txtSenha2" Display="Dynamic" ErrorMessage="Confirme a senha"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtSenha" ControlToValidate="txtSenha2" Display="Dynamic" 
                    ErrorMessage="Senhas não conferem."></asp:CompareValidator>
                </td>
        </tr>
        <tr>
            <td class="style20">
                O usuário é Administrador?
                <asp:RadioButtonList ID="isAdmin" runat="server">
                    <asp:ListItem Value="True">Sim</asp:ListItem>
                    <asp:ListItem Selected="True" Value="False">Não</asp:ListItem>
                </asp:RadioButtonList>
                </td>
        </tr>
        <tr>
            <td class="style18">
                <asp:Button ID="Button1" runat="server" Height="45px" Text="Salvar Alterações" 
                    Width="120px" onclick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" Height="45px" 
                    onclick="Button2_Click" Text="Cancela" Width="98px" />
                </td>
        </tr>
        </table>
</asp:Content>

