<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="RepeaterPage.aspx.cs" Inherits="HeroesWeb.RepeaterPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="display-5 text-center my-4">Tarjetas de superhéroes</h1>
    <h1 class="display-6 text-center my-4">Repeater</h1>
    <div class="row row-cols-1 row-cols-4 g-4">
        <asp:Repeater ID="repeaterHeroes" runat="server">
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("url")%>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("alias")%></h5>
                        <p class="card-text">Universo <%#Eval("universo")%></p>
                        <p class="card-text"><small class="text-body-secondary">Last updated 3 mins ago</small></p>
                        <a href="DetalleHeroe.aspx?id=<%#Eval("id")%>">Conocer</a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
