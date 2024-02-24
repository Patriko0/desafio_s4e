<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Desafio_S4E.Views.User.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Usuários
    </h1>
    <asp:Button ID="BTN_Create" runat="server" Text="Criar usuario" CssClass="btn btn-primary" OnClick="BTN_Create_Click"/>

    <table class="table table-striped table-bordered">
    <thead class="bg-dark text-white">
        <tr>
            <th scope="col">Id</th>
            <th scope="col">Nome</th>
        </tr>
    </thead>
    
</table>
</asp:Content>
