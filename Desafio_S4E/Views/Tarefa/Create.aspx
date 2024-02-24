<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Desafio_S4E.Views.Tarefa.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Criar Tarefa</h1>

    <asp:Label ID="LB_Desc" runat="server" Text="Descrição: "></asp:Label>
    <asp:TextBox ID="TXT_Desc" runat="server"></asp:TextBox>
    <asp:Button ID="BTN_Salvar" CssClass="btn btn-primary" runat="server" Text="Button" OnClick="BTN_Salvar_Click" />
</asp:Content>
