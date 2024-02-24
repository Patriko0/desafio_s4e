<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Desafio_S4E.Views.User.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Criar usuario</h1>

    <asp:Label ID="LabelNome" runat="server" Text="Nome"></asp:Label>
    <asp:TextBox ID="TXT_Nome" runat="server"></asp:TextBox>
    <asp:Button ID="BTN_Save" runat="server" Text="Salvar" CssClass="btn btn-danger" OnClick="BTN_Save_Click"/>
</asp:Content>
