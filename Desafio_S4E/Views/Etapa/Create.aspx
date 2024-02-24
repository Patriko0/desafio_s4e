<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Desafio_S4E.Views.Etapa.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="LB_Desc" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TXT_Desc" runat="server"></asp:TextBox>
    
    <asp:Button ID="BTN_Salvar" runat="server" Text="Salvar" OnClick="BTN_Salvar_Click"/>
</asp:Content>
