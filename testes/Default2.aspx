<%@ Page Language="C#" MasterPageFile="~/testes/ajaxMasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="testes_Default2" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
     <ContentTemplate>
     <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" style="width: 136px" Text="Carregar Dados" />
     </ContentTemplate>
    
    </asp:UpdatePanel>
    <div>
       <p>
        Páina PADRÃO! DEFAULT2</p>      
<asp:UpdateProgress ID="UpdateProgress1" runat="server">
<ProgressTemplate>
  Atualizando Dados...
</ProgressTemplate>
</asp:UpdateProgress>

        
    <p>

    </p>
    </div>
</asp:Content>

