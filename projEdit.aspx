<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="projEdit.aspx.cs" Inherits="projList" Title="Editar Projeto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style10
        {
            height: 22px;
        }
        .style14
        {
            height: 8px;
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
        .style19
        {
            height: 60px;
        }
        .style20
        {
            height: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 class="titulo1">Editar Projeto (#<%=Request.QueryString["ID"]%>)</h1>
    <table cellpadding="0" cellspacing="0" class="conteudo" style="width:100%;">
        <tr >
            <td class="style15">
                Requerente<br />
                <asp:TextBox ID="txtRequerente" runat="server" Width="321px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtRequerente" 
                    ErrorMessage="É necessário especificar um Requerente."></asp:RequiredFieldValidator>
                </td>
            <td class="style10">
                &nbsp;</td>
        </tr>
        <tr >
            <td class="style15">
                Nome do Projeto<br />
                <asp:TextBox ID="txtNome" runat="server" Width="239px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNome" ErrorMessage="Digite um nome para o projeto"></asp:RequiredFieldValidator>
                </td>
            <td class="style10">
                </td>
        </tr>
        <tr>
            <td class="style16">
                Valor do Projeto (R$)<br />
                <asp:TextBox ID="txtValorProjeto" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtValorProjeto" Display="Dynamic" 
                    ErrorMessage="Digite um Custo Estimado para o Projeto."></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtValorProjeto" Display="Dynamic" 
                    ErrorMessage="Valor inválido!" 
                    ValidationExpression="[0-9]{0,10}(,[0-9]{1,4})?"></asp:RegularExpressionValidator>
                </td>
            <td class="style20">
                </td>
        </tr>
        <tr>
            <td class="style16">
                Custo atual do projeto (R$)<br />
                <asp:TextBox ID="txtCustoAtual" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="txtCustoAtual" Display="Dynamic" 
                    ErrorMessage="Entre com o custo atual do Projeto."></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                    ControlToValidate="txtCustoAtual" Display="Dynamic" 
                    ErrorMessage="Valor inválido!" 
                    ValidationExpression="[0-9]{0,10}(,[0-9]{1,4})?"></asp:RegularExpressionValidator>
                </td>
            <td class="style20">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style17">
                Data de Início<br />
                <asp:TextBox ID="txtDataInicio" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtDataInicio" Display="Dynamic" 
                    ErrorMessage="Digite a Data de Início do projeto"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="txtDataInicio" Display="Dynamic" 
                    ErrorMessage="Data inválida!" 
                    ValidationExpression="[0-9]{1,2}/[0-9]{1,2}/[0-9]{4}"></asp:RegularExpressionValidator>
                </td>
            <td class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style17">
                Data de Termino
                <br />
                <asp:TextBox ID="txtDataTermino" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtDataTermino" Display="Dynamic" 
                    ErrorMessage="Digite a Data de Termino prevista para o Projeto"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                    ControlToValidate="txtDataTermino" Display="Dynamic" 
                    ErrorMessage="Data inválida!" 
                    ValidationExpression="[0-9]{1,2}/[0-9]{1,2}/[0-9]{4}"></asp:RegularExpressionValidator>
                </td>
            <td class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style17">
                Descrição do Projeto
                <asp:TextBox ID="txtDescricaoProjeto" runat="server" Height="123px" TextMode="MultiLine" 
                    Width="482px"></asp:TextBox>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtDescricaoProjeto" 
                    ErrorMessage="Digite a descrição do Projeto"></asp:RequiredFieldValidator>
                </td>
            <td class="style14">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style18">
                <asp:Button ID="Button1" runat="server" Height="45px" Text="Salvar Alterações" 
                    Width="113px" onclick="Button1_Click" />
                &nbsp;<asp:Button ID="Button2" runat="server" CausesValidation="False" Height="45px" 
                    onclick="Button2_Click" Text="Cancela" Width="98px" />
                </td>
            <td class="style19">
                </td>
        </tr>
        </table>
</asp:Content>

