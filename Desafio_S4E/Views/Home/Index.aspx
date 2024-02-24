<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Desafio_S4E._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Desafio S4E</h1>
            <p class="lead">Sistema de gerenciamento de tarefas</p>
        </section>

        <div class="row">
            <div class="col">
                <div class="row mb-3">
                    <asp:Button ID="BTN_Users" CssClass="btn btn-primary w-25" runat="server" Text="Acessar usuarios" OnClick="BTN_Users_Click"/>

                </div>
                <div class="row">
                    <asp:Button ID="BTN_Tarefas" CssClass="btn btn-primary w-25" runat="server" Text="Acessar tarefas" OnClick="BTN_Tarefas_Click" />

                </div>

            </div>

        </div>

        
    </main>

</asp:Content>
