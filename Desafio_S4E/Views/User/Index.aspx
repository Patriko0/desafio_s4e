<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Desafio_S4E.Views.User.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Usuários
    </h1>
    <asp:Button ID="BTN_Create" runat="server" Text="Criar usuario" CssClass="btn btn-primary" OnClick="BTN_Create_Click"/>

    <div class="row my-4">
        <div class="col-2 flex-column align-items-center justify-content-center align-content-center">

        <asp:DropDownList ID="DropDownList" runat="server" DataSourceID="SqlDataSourceUsuarios" DataTextField="nome" DataValueField="id"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceUsuarios" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [id], [nome] FROM [Usuario]"></asp:SqlDataSource>
        </div>
        <div class="col-3 flex-column">
        <asp:Button ID="BTN_AddTarefa" runat="server" CssClass="btn btn-info" Text="Adicionar Tarefa" OnClick="BTN_AddTarefa_Click" />
        </div>
        <div class="col-3 flex-column">
        <asp:Button ID="BTN_Delete" runat="server" CssClass="btn btn-danger" Text="Deletar usuario" OnClick="BTN_Delete_Click" />
        </div>



    </div>
    

    <table class="table table-striped table-bordered">
    <thead class="bg-dark text-white">
        <tr>
            <th scope="col">Id</th>
            <th scope="col">Nome</th>
        </tr>
    </thead>
        <tbody>
            <%foreach (Desafio_S4E.Models.UserModel user in Session["users"] as List<Desafio_S4E.Models.UserModel>)
            {  %>
            <tr>
            <th scope="row"><%= user.Id %></th>
            <td><%= user.Name %></td>
            </tr>
            <% } %>
        </tbody>
    
</table>
</asp:Content>
