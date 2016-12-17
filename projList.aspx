<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="projList.aspx.cs" Inherits="projList" Title="Lista de Projetos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style11
        {
            height: 171px;
        }
        .style12
        {
            height: auto;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="titulo1">Meus Projeto(s)</h1>
    <table cellpadding="0" cellspacing="0" class="conteudo" style="width:100%;">
        
        <tr>
            <td class="style12" style="padding-left: 10px; vertical-align:top">
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="projDelete">
                <HeaderTemplate>
                <table>
                <tr>
                    <td style=" width:150px"><b>Nome</b></td>
                    <td style=" width:120px"><b>Requerente</b></td>
                    <td style=" width:115px"><b>Valor</b></td>
                    <td style=" width:100px"><b>Gasto Atual</b></td>
                    <td style=" width:100px"><b>Data de Início</b></td>
                    
                </tr>
                </HeaderTemplate>
                <ItemTemplate>
                <tr>
                    <td><%# Eval("Nome")%></td>
                    <td><%# Eval("Requerente")%></td>
                    <td><%# String.Format("{0:C}",Eval("ValorProjeto")) %></td>
                    <td><%# String.Format("{0:C}",Eval("GastoAtual")) %></td>
                    <td><%# Eval("DataDeInicio")%> </td>
                    <td> <asp:ImageButton ImageUrl="~/images/btEditProjeto.gif" CommandName="Editar" CommandArgument=<%# Eval("idProjeto")%> ID="ImageButton1" Text="Deletar" runat="server" /></td>
                    <td> <asp:ImageButton ImageUrl="~/images/btDelProject.gif" CommandName="Deletar" CommandArgument=<%# Eval("idProjeto")%> ID="ImageButton2" Text="Deletar" runat="server" /></td>
                </tr>
                </ItemTemplate>
                <FooterTemplate>
                </table>
                </FooterTemplate>
                </asp:Repeater>
                <br />
                <hr />
                <a href="projAdd.aspx">
                <img alt="Adicionar um Novo Projeto" src="images/btNovoProjeto.gif" 
                    style="width: 100px; height: 20px;"  /></a></td>
        </tr>
        <tr>
            <td class="style11" style="padding-left: 10px; vertical-align:top">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>

