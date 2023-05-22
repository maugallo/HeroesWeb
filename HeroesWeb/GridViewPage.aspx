<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="GridViewPage.aspx.cs" Inherits="HeroesWeb.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="display-5 text-center my-4">Tabla de superhéroes</h1>
    <asp:GridView CssClass="table table-bordered" ID="GridHeroes" runat="server" AutoGenerateColumns="false">
        <HeaderStyle BackColor="#343a40" ForeColor="White" />
        <Columns>
            <asp:BoundField HeaderText="Alias" DataField="alias" />
            <asp:BoundField HeaderText="Poder" DataField="poder" />
            <asp:BoundField HeaderText="Universo" DataField="universo" />
        </Columns>
    </asp:GridView>
</asp:Content>
