<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HeroesWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        
    </div>
    <div class="row">
        <div class="col-2"></div>
        <div class="col-8">
            <div class="p-4 mb-3 bg-body-tertiary rounded">
                <h2 class="text-center my-3">¡Bienvenidos a Mundo Héroe!</h2>
                <p class="lead">
                    Esta web fue creada para poder ver las distintas formas en la que una aplicación web
                    puede interactuar con una base de datos, y las distintas formas en las que pueden mostrarse
                    los registros de una tabla. A continuación, haz click en cualquiera de las pestañas del header
                    para ver las distintas formas de ver los objetos de nuestra tabla <span class="text-decoration-underline">Superhéroes</span>.
                </p>
            </div>

        </div>
        <div class="col-2"></div>
        <div class="row featurette">
            <div class="col-6">
                <h2 class="featurette-heading fw-normal lh-1">Mostrar tabla mediante GridView. <a class="link-secondary text-decoration-none" runat="server" href="~/GridViewPage.aspx">Haz click para ver.</a></h2>
                <p class="lead">Podemos conectar nuestro sitio a una base de datos y reflejar sus valores en una GridView de una manera muy fácil.</p>
            </div>
            <div class="col-3"></div>
            <div class="col-3"></div>
        </div>
        <hr />
        <div class="row featurette">
            <div class="col-3"></div>
            <div class="col-6">
                <h2 class="featurette-heading fw-normal lh-1">Mostrar tabla mediante ForEach. <a class="link-secondary text-decoration-none" runat="server" href="~/ForEachPage.aspx">Haz click para ver.</a></h2>
                <p class="lead">Podemos extraer una lista de registros de la tabla y reflejarla manualmente mediante un ForEach.</p>
            </div>
            <div class="col-3"></div>
        </div>
        <hr />
        <div class="row featurette">
            <div class="col-3"></div>
            <div class="col-3"></div>
            <div class="col-6">
                <h2 class="featurette-heading fw-normal lh-1">Mostrar tabla mediante Repeater. <a class="link-secondary text-decoration-none" runat="server" href="~/RepeaterPage.aspx">Haz click para ver.</a></h2>
                <p class="lead">De la misma forma que un ForEach, podemos extraer a través de una lista los registros de la tabla y mostrarlos de forma muy similar en un Repeater.</p>
            </div>
        </div>
    </div>

</asp:Content>
