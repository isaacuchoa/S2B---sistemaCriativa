<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userList.aspx.cs" Inherits="userList" Title="Lista de Usuários" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="titulo1">Usuário(s)</h1>
    <table cellpadding="0" cellspacing="0" class="conteudo" style="width:100%;">
        
        <tr>
            <td class="style12" style="padding-left: 10px; vertical-align:top">
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="FuncoesDeUsuario">
                <HeaderTemplate>
                <table>
                <tr>
                    <td style=" width:120px"><b>Nome</b></td>
                    <td style=" width:60px"><b>Login</b></td>
                    <td style=" width:240px"><b>Contato</b></td>
                    <td style=" width:130px"><b>Último Acesso</b></td>
                    
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                <tr>
                    <td><%# Eval("Nome")%></td>
                    <td><%# Eval("Login")%></td>
                    <td><%# string.Concat(Eval("Email"), " - " , Eval("Celular")) %></td>
                    <td><%# Eval("Ultimo_Acesso") %></td>
                    <td> <asp:ImageButton ImageUrl="~/images/btEditProjeto.gif" CommandName="Editar" CommandArgument=<%# Eval("idUsuario")%> ID="ImageButton1" Text="Deletar" runat="server" /></td>
                    <td> <asp:ImageButton ImageUrl="~/images/btDelUsuario.gif" CommandName="Deletar" CommandArgument=<%# Eval("idUsuario")%> ID="ImageButton2" Text="Deletar" runat="server" /></td>
                </tr>
                </ItemTemplate>
                <FooterTemplate>
                </table>
                </FooterTemplate>
                </asp:Repeater>
                <br />
                <hr />
                <a href="userAdd.aspx">
                <img alt="Adicionar um Novo Usuário" src="images/btAddUsuario.gif" 
                    style="width: 100px; height: 20px;"  /></a></td>
        </tr>
        <tr>
            <td class="style11" style="padding-left: 10px; vertical-align:top">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

