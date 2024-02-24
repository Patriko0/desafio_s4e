<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Desafio_S4E.Views.Tarefa.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Tarefas</h1>
    <div>

        <asp:DropDownList ID="DropDownList" runat="server" DataSourceID="SqlDataSourceUsuarios" DataTextField="nome" DataValueField="id" OnSelectedIndexChanged="DropDownList_SelectedIndexChanged"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSourceUsuarios" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [id], [nome] FROM [Usuario]"></asp:SqlDataSource>

    </div>

    <table class="table table-striped table-bordered">
        <thead class="bg-dark text-white">
            <tr>

                <th scope="col">Id</th>
                <th scope="col">Decrição</th>
                <th scope="col">Data de Inicio</th>
                <th scope="col">Data de Conclusão</th>
            </tr>
        </thead>
        <tbody>
            <%foreach (Desafio_S4E.Models.TarefaModel tarefa in Session["tarefas"] as List<Desafio_S4E.Models.TarefaModel>)
                {  %>
            <tr>
                <th scope="row"><%= tarefa.Id %></th>
                <td><%= tarefa.Desc %></td>
                <td><%= tarefa.DataInicio %></td>
                <td></td>

            </tr>
            <% } %>
        </tbody>
    </table>

</asp:Content>
