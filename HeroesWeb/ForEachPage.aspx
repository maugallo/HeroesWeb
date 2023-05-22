<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ForEachPage.aspx.cs" Inherits="HeroesWeb.Tarjetas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="display-5 text-center my-4">Tarjetas de superhéroes</h1>
    <h1 class="display-6 text-center my-4">ForEach</h1>
    <div class="row row-cols-1 row-cols-4 g-4">
        <% 
            foreach (Dominio.Superheroe heroe in ListaHeroes)
            {
        %>
        <div class="card">
            <img src="<%: heroe.Url %>" class="card-img-top" alt="...">
            <div class="card-body">
                <h5 class="card-title"><%: heroe.Alias %></h5>
                <p class="card-text">Universo <%: heroe.Universo %></p>
                <p class="card-text"><small class="text-body-secondary">Last updated 3 mins ago</small></p>
                <a href="DetalleHeroe.aspx?id=<%: heroe.Id %>">Conocer</a>
            </div>
        </div>
        <% 
            }
        %>
    </div>
</asp:Content>
