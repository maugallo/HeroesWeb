<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="DetalleHeroe.aspx.cs" Inherits="HeroesWeb.DetalleHeroe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="display-5 text-center my-4">Detalle del Superhéroe</h1>
    <asp:GridView CssClass="table table-bordered" ID="gridHeroes" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="Alias" DataField="alias" />
            <asp:BoundField HeaderText="Nombre" DataField="nombre" />
            <asp:BoundField HeaderText="Apellido" DataField="apellido" />
            <asp:BoundField HeaderText="Edad" DataField="edad" />
            <asp:BoundField HeaderText="Poder" DataField="poder" />
            <asp:BoundField HeaderText="Universo" DataField="universo" />
        </Columns>
    </asp:GridView>
    <img src="<%: Heroe.Url %>" class="mx-auto d-block w-25 rounded" alt="...">
    <div class=""></div>
</asp:Content>
